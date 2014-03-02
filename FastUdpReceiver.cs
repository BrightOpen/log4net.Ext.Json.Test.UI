using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace log4net.Json.Test.UI
{
    public class FastUdpReceiver : IDisposable
    {
        #region Public events and properties
        public event MessageReceivedHandler Received;
        public event ErrorEncounteredHandler Error;

        public int BufferSize { get { return m_BufferSize; } set { m_BufferSize = value; } }
        public int Sleepiness { get { return m_Sleepiness; } set { m_Sleepiness = value; } }
        public int ExpectedCalls { get { return m_ExpectedCalls; } set { m_ExpectedCalls = value; } }
        public bool IsAlive { get { return m_KeepReceiving && m_Socket.IsBound; } }
        public int AvailableCalls { get { return m_AvailableCalls; } }
        public int WaitingCalls { get { return m_WaitingCalls; } }
        public int ExecutingCalls { get { return m_ExecutingCalls; } }
        #endregion

        #region Private fields
        int m_BufferSize = 64 * 1024;
        int m_Sleepiness = 1;
        int m_ExpectedCalls = 108;

        int m_AvailableCalls;
        int m_WaitingCalls;
        int m_ExecutingCalls;

        readonly ConcurrentBag<SocketAsyncEventArgs> m_FreeSocketEABag = new ConcurrentBag<SocketAsyncEventArgs>();
        readonly Socket m_Socket;
        readonly bool m_OwnSocket;
        bool m_KeepReceiving;
        #endregion

        #region Constructors
        /// <summary>
        /// Create an instance and bind own private socket on the UDP port on "Any" IP address. Socket is then taken down on Stop.
        /// </summary>
        /// <param name="localEndPoint"></param>
        public FastUdpReceiver(int port)
            : this(new IPEndPoint(IPAddress.Any, port))
        {
        }

        /// <summary>
        /// Create an instance and bind own private socket on the UDP endpoint. Socket is then taken down on Stop.
        /// </summary>
        /// <param name="localEndPoint"></param>
        public FastUdpReceiver(IPEndPoint localEndPoint)
            : this(Bind(localEndPoint), true)
        {
            m_OwnSocket = true;
        }

        /// <summary>
        /// Create an instance with an existing socket. It must be bound on UDP endpoint. Socket is taken down on Stop if <paramref name="ownSocket"/> is true.
        /// </summary>
        /// <param name="boundUdpSocket"></param>
        /// <remarks>
        /// This can be used for Multicast 
        /// </remarks>
        public FastUdpReceiver(Socket boundUdpSocket, bool ownSocket)
        {
            if (boundUdpSocket == null) throw new ArgumentNullException("boundUdpSocket");
            if (!boundUdpSocket.IsBound) throw new ArgumentException("Socket must be bound", "boundUdpSocket");
            if (boundUdpSocket.ProtocolType != ProtocolType.Udp) throw new ArgumentException("Socket must have UDP protocol type", "boundUdpSocket");

            m_Socket = boundUdpSocket;
            m_OwnSocket = ownSocket;
        }
        #endregion

        public void Execute()
        {
            this.m_KeepReceiving = true;

            try
            {
                LoopReceive();
            }
            catch (Exception x)
            {
                OnErrorEncountered(x, "UDPReceiverRun loop receive failed.");
            }
            finally
            {
                Stop();
            }
        }

        public void Stop()
        {
            m_KeepReceiving = false;

            SocketAsyncEventArgs readEA;
            while (m_FreeSocketEABag.Count != 0 && m_FreeSocketEABag.TryTake(out readEA))
                readEA.Dispose();

            var socket = m_Socket;
            if (m_OwnSocket && socket != null && socket.IsBound)
            {
                try
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    m_Socket.Dispose();
                }
                catch (ObjectDisposedException x)
                {
                    // it's been done already
                    OnErrorEncountered(x, "Already disposed");
                }
            }
        }

        public void Dispose()
        {
            Stop();
        }

        protected void LoopReceive()
        {
            SocketAsyncEventArgs readEA;

            while (m_KeepReceiving)
            {
                while (!m_FreeSocketEABag.TryTake(out readEA))
                {
                    if (!m_KeepReceiving) break;

                    if (m_AvailableCalls + m_ExecutingCalls + m_WaitingCalls < m_ExpectedCalls)
                    {
                        Interlocked.Increment(ref m_AvailableCalls);
                        var buffer = new byte[m_BufferSize];
                        readEA = new SocketAsyncEventArgs();
                        readEA.SetBuffer(buffer, 0, buffer.Length);
                        readEA.Completed += ReceiveCompleted;
                        m_FreeSocketEABag.Add(readEA);
                    }
                    else
                    {
                        if (m_ExecutingCalls > m_WaitingCalls)
                        {
                            m_ExpectedCalls++;
                        }
                        else if (m_Sleepiness >= 0)
                        {
                            Thread.Sleep(m_Sleepiness);
                        }
                    }
                }

                if (!m_KeepReceiving) break;

                Interlocked.Increment(ref m_WaitingCalls);
                Interlocked.Decrement(ref m_AvailableCalls);

                readEA.AcceptSocket = m_Socket;
                readEA.RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

                if (!m_Socket.ReceiveMessageFromAsync(readEA))
                {
                    ThreadPool.QueueUserWorkItem((state) => ReceiveCompleted(m_Socket, readEA));
                }
            }
        }


        protected void ReceiveCompleted(object sender, SocketAsyncEventArgs e)
        {
            try
            {
                Interlocked.Increment(ref m_ExecutingCalls);
                Interlocked.Decrement(ref m_WaitingCalls);

                switch (e.LastOperation)
                {
                    case SocketAsyncOperation.Receive:
                    case SocketAsyncOperation.ReceiveFrom:
                    case SocketAsyncOperation.ReceiveMessageFrom:
                        OnMessageReceived(e);
                        break;
                    default:
                        OnErrorEncountered(null, "It's a UDP receiver, fast, but it would only receive. Got {0}", e.LastOperation);
                        break;
                }
            }
            catch (Exception x)
            {
                OnErrorEncountered(x, "ReceiveMessage failed.");
            }
            finally
            {
                Interlocked.Increment(ref m_AvailableCalls);
                Interlocked.Decrement(ref m_ExecutingCalls);
                m_FreeSocketEABag.Add(e);
            }
        }

        protected void OnMessageReceived(SocketAsyncEventArgs e)
        {
            if (e.BytesTransferred > 0 && e.SocketError == SocketError.Success)
            {
                var data = Encoding.UTF8.GetString(e.Buffer, e.Offset, e.BytesTransferred);

                var call = Received;

                if (call != null) call(this, data, e.RemoteEndPoint);
            }
            else
            {
                OnErrorEncountered(null, "Socket receive error: {0}", e.SocketError);
            }
        }

        protected void OnErrorEncountered(Exception x, string descriptionformat, params object[] formatargs)
        {
            var call = Error;
            var throwError = true;
            var description = descriptionformat;

            try
            {
                description = String.Format(descriptionformat, formatargs);
            }
            catch
            {
                // ignore formatting errors and use the description format only.
            }

            if (call != null) call(this, description, x, ref throwError);

            if (throwError) throw new Exception(description, x);
        }

        public delegate void MessageReceivedHandler(FastUdpReceiver fromReceiver, String data, EndPoint remoteEndpoint);
        public delegate void ErrorEncounteredHandler(FastUdpReceiver fromReceiver, String description, Exception x, ref bool throwError);

        static Socket Bind(IPEndPoint localEndPoint)
        {
            var socket = new Socket(localEndPoint.Address.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(localEndPoint);
            return socket;
        }

    }


}
