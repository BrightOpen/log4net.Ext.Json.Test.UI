using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace log4net.Json.Test.UI
{
    public partial class BenchRun : UserControl
    {
        ILog log;

        /// <summary>
        /// -1 = unprepared
        /// 0 = ready
        /// 1 = started
        /// 2 = done
        /// </summary>
        int State = -1;

        Thread[] GeneratorThreads = new Thread[1];
        int ThreadsAlive = 0;
        int EventsPerThreadVar = 1;
        int EventsDoneVar = 0;
        Stopwatch watch = new Stopwatch();

        public bool Ready { get { return State == 0; } }
        public bool Started { get { return State == 1; } }
        public bool Done { get { return State == 2; } }

        public int EventsPerThread
        {
            get { return EventsPerThreadVar; }
            set
            {
                EventsPerThreadVar = value;
                Caption = String.Format("#{0}: {1}x{2} {3}/{4}", Set, NumberOfThreads, EventsPerThread, NumberOfEventsDone, NumberOfEventsScheduled);
                UIAction(() => { progBar.Maximum = EventsPerThread * NumberOfThreads; });
            }
        }
        public int NumberOfThreads
        {
            get { return GeneratorThreads.Length; }
            set
            {
                GeneratorThreads = new Thread[value];
                Caption = String.Format("#{0}: {1}x{2} {3}/{4}", Set, NumberOfThreads, EventsPerThread, NumberOfEventsDone, NumberOfEventsScheduled);
                UIAction(() => { progBar.Maximum = EventsPerThread * NumberOfThreads; });
            }
        }
        public int NumberOfEventsScheduled
        {
            get { return progBar.Maximum; }
        }
        public int NumberOfEventsDone
        {
            get { return progBar.Value; }
            set
            {
                UIAction(() => { progBar.Value = value; });
                Caption = String.Format("#{0}: {1}x{2} {3}/{4}", Set, NumberOfThreads, EventsPerThread, NumberOfEventsDone, NumberOfEventsScheduled);
            }
        }
        public Color Color
        {
            get { return lCaption.ForeColor; }
            set { UIAction(() => { lCaption.ForeColor = value; }); }
        }
        public string Caption
        {
            get { return lCaption.Text; }
            protected set { UIAction(() => { lCaption.Text = value; }); }
        }
        public string LoggerName
        {
            get { return lLogger.Text; }
            set { UIAction(() => { lLogger.Text = value; }); }
        }
        public string Stats
        {
            get { return lSent.Text; }
            set { UIAction(() => { lSent.Text = value; }); }
        }

        public int Set { get; set; }
        public int Sleepiness { get; set; }
        public TimeSpan Timing { get; private set; }
        public DateTime Date { get; private set; }
        public bool Success { get; private set; }
        public bool Detailed
        {
            get { return lLogger.Visible; }
            set
            {
                UIAction(() =>
                {
                    var rowHeight = 18;
                    lLogger.Visible = value;
                    label1.Visible = value;
                    this.Height = value ? rowHeight * 3 : rowHeight;
                });
            }
        }

        public BenchRun()
        {
            InitializeComponent();
            NumberOfEventsDone = 0;
            Detailed = false;
            Disposed += BenchRun_Disposed;
        }

        public void Prepare()
        {
            if (-1 != Interlocked.CompareExchange(ref State, 0, -1)) return;

            var fixedLoggerName = String.IsNullOrEmpty(LoggerName) ? GetType().FullName : LoggerName;
            log = LogManager.GetLogger(fixedLoggerName);

            for (var i = 0; i < GeneratorThreads.Length; i++)
            {
                GeneratorThreads[i] = new Thread(Run);
                GeneratorThreads[i].Name = this.Name;
            }

            GeneratorThreads.All(t => { t.Start(); return true; });

            Color = Color.DarkBlue;
        }
        public void Start()
        {
            Date = DateTime.Now;
            watch.Start();
            Interlocked.CompareExchange(ref State, 1, 0);
        }

        public void Stop()
        {
            State = 2;
        }

        protected void UIAction(Action action)
        {
            if (Disposing || IsDisposed) return;

            if (InvokeRequired)
                Invoke(new Action<Action>(UIAction), action);
            else
                action();
        }

        void Run()
        {
            Interlocked.Increment(ref ThreadsAlive);

            try
            {
                var c = EventsPerThread;
                var sleep = Sleepiness;

                if (log.IsDebugEnabled) log.Debug("Ready");

                while (State == 0) Thread.Sleep(1);

                for (int i = 0; i < c; i++)
                {
                    if (State != 1) break;

                    if (log.IsDebugEnabled) log.DebugFormat("Event #{0}", NumberOfEventsDone);

                    NumberOfEventsDone = Interlocked.Increment(ref EventsDoneVar);

                    if (sleep >= 0) Thread.Sleep(sleep);
                }
            }
            finally
            {
                Interlocked.Decrement(ref ThreadsAlive);
                ThreadStop();
            }
        }

        protected void ThreadStop()
        {
            if (ThreadsAlive != 0) return;

            State = 2;

            watch.Stop();

            Timing = watch.Elapsed;

            if (NumberOfEventsScheduled != NumberOfEventsDone)
            {
                Color = Color.DarkRed;
                Success = false;
            }
            else
            {
                Color = Color.DarkGreen;
                Success = true;
            }
            Stats = String.Format("Score:{2} for {3} threads. Sent {0:###,###,###} events in {1}."
                , NumberOfEventsDone
                , Timing
                , NumberOfEventsDone / Timing.TotalMilliseconds
                , NumberOfThreads);

            if (log.IsDebugEnabled) log.Debug(Stats);
        }

        private void lCaption_Click(object sender, EventArgs e)
        {
            Detailed = !Detailed;
        }

        void BenchRun_Disposed(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
