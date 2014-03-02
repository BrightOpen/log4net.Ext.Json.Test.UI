using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Web.Script.Serialization;
using log4net.Core;
using System.Collections;
using log4net.Util;
using System.Collections.Concurrent;

namespace log4net.Json.Test.UI
{
    public class LogUdpReceiver
    {
        public int Port { get; set; }
        public int ExpectedCalls { get; set; }
        public int Sleepiness { get; set; }

        public bool IsAlive { get { return Receiver == null ? false : Receiver.IsAlive; } }
        public int ExecutingCalls { get { return Receiver == null ? 0 : Receiver.ExecutingCalls; } }
        public int WaitingCalls { get { return Receiver == null ? 0 : Receiver.WaitingCalls; } }
        public int AvailableCalls { get { return Receiver == null ? 0 : Receiver.AvailableCalls; } }
        public long MessageCount { get { return Count; } }

        static JavaScriptSerializer Serializer = new JavaScriptSerializer();
        FastUdpReceiver Receiver;
        Thread ReceiverThread;
        long Count;

        public LogUdpReceiver()
        {
            Sleepiness = 7;
            Port = 55555;
            ExpectedCalls = 200;
        }

        public void Stop()
        {
            lock (this)
            {
                var r = Receiver; Receiver = null;
                var t = ReceiverThread; ReceiverThread = null;
                if (r != null) r.Stop();
                if (t != null && t.IsAlive && !t.Join(Sleepiness + 500))
                {
                    t.Abort("Stop");
                }
            }
        }

        public void Start()
        {
            lock (this)
            {
                Stop();

                Receiver = new FastUdpReceiver(Port) { Sleepiness = Sleepiness, ExpectedCalls = ExpectedCalls };
                Receiver.Received += Receiver_Received;
                Receiver.Error += Receiver_Error;

                Count = 0;

                ReceiverThread = new Thread(Receiver.Execute);
                ReceiverThread.Name = "LogUdpReceiver" + ReceiverThread.ManagedThreadId.ToString();
                ReceiverThread.Priority = ThreadPriority.AboveNormal;
                ReceiverThread.Start();
            }
        }

        void Receiver_Received(FastUdpReceiver fromReceiver, string data, EndPoint remoteEndpoint)
        {
            try
            {
                var boundaryType = typeof(LogUdpReceiver);
                var dict = (IDictionary)Serializer.DeserializeObject(data);
                var remoteEndPoint = Convert.ToString(remoteEndpoint).Replace(":", ".");
                var logger = String.Format("Remote.{0}.{1}", dict["logger"], remoteEndPoint);
                var thislog = LogManager.GetLogger(logger);
                var repo = thislog.Logger.Repository;
                var level = repo.LevelMap.LookupWithDefault(new Level(Level.Info.Value, (string)dict["level"]));
                var message = dict["message"];

                Exception exception = null;
                var exceptionData = dict["exception"] as string;
                if (String.IsNullOrEmpty(exceptionData))
                    exception = new ReceivedException(exceptionData);

                var loggingEvent = new LoggingEvent(boundaryType, repo, logger, level, message, exception);

                thislog.Logger.Log(loggingEvent);
            }
            catch (Exception x)
            {
                LogLog.Error(GetType(), "Unrecognized event: " + data, x);
            }
            finally
            {
                Interlocked.Increment(ref Count);
            }
        }

        void Receiver_Error(FastUdpReceiver fromReceiver, string description, Exception x, ref bool throwError)
        {
            LogLog.Error(fromReceiver.GetType(), description, x);
            throwError = false;
        }


        /*
        protected void Receive()
        {
            var meType = typeof(UDPReceiver);
            Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
            try
            {
                using (var client = new UdpClient(Port))
                {
                    client.Client.ReceiveBufferSize = 0;
                    client.Client.UseOnlyOverlappedIO = true;
                    var sleep = Sleepiness;
                    var expected = ExpectedCalls;

                    while (KeepReceiving)
                    {
                        if (Calls < expected)
                        {
                            // queue calls up to the expected numer
                            Interlocked.Increment(ref Calls);
                            var ar = client.BeginReceive(Received, client);
                        }
                        else if (sleep >= 0)
                        {
                            Thread.Sleep(sleep);
                        }
                    }

                    lock (client)
                        client.Close();
                }
            }
            catch (Exception x)
            {
                LogLog.Error(meType, "Receiver failed", x);
            }
        }
        
        protected void Received(IAsyncResult ar)
        {
            try
            {
                byte[] buffer;
                IPEndPoint remoteEndPoint = null;
                var client = ar.AsyncState as UdpClient;
                if (client == null) return;
                lock (client)
                {
                    if (client.Client == null) return;
                    buffer = client.EndReceive(ar, ref remoteEndPoint);
                }

                var data = System.Text.Encoding.UTF8.GetString(buffer);

                try
                {
                    var boundaryType = typeof(UDPReceiver);
                    var dict = (IDictionary)serializer.DeserializeObject(data);
                    var logger = String.Format("Remote.{0}.{1}.{2}", dict["logger"], remoteEndPoint.Address, remoteEndPoint.Port);
                    var thislog = LogManager.GetLogger(logger);
                    var repo = thislog.Logger.Repository;
                    var level = repo.LevelMap.LookupWithDefault(new Level(Level.Info.Value, (string)dict["level"]));
                    var message = dict["message"];
                    Exception exception = null;
                    var exceptionData = dict["exception"];
                    if (exceptionData != null)
                        exception = new ReceivedException(exceptionData);
                    var loggingEvent = new LoggingEvent(boundaryType, repo, logger, level, message, exception);
                    thislog.Logger.Log(loggingEvent);
                }
                catch (Exception x)
                {
                    LogLog.Error(GetType(), "Unrecognized event: " + data, x);
                }
            }
            catch (Exception x)
            {
                LogLog.Error(GetType(), "Receive failed.", x);
            }
            finally
            {
                Interlocked.Decrement(ref Calls);
                Interlocked.Increment(ref Count);
            }
        }

        */

    }


    public class ReceivedException : Exception
    {
        public ReceivedException(object exceptionData)
            : base("ReceivedException: " + exceptionData)
        {
        }
    }
}
