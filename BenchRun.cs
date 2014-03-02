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

        readonly Thread GeneratorThread;

        /// <summary>
        /// -1 = unprepared
        /// 0 = ready
        /// 1 = started
        /// 2 = done
        /// </summary>
        int State = -1;

        public bool Ready { get { return State == 0; } }
        public bool Started { get { return State == 1; } }
        public bool Done { get { return State == 2; } }

        public int NumberOfEvents
        {
            get { return progBar.Maximum; }
            set { Action(() => { progBar.Maximum = value; }); }
        }
        public int NumberOfEventsDone
        {
            get { return progBar.Value; }
            set { Action(() => { progBar.Value = value; }); }
        }
        public Color Color
        {
            get { return lCaption.ForeColor; }
            set { Action(() => { lCaption.ForeColor = value; }); }
        }
        public string Caption
        {
            get { return lCaption.Text; }
            set { Action(() => { lCaption.Text = value; }); }
        }
        public string LoggerName
        {
            get { return lLogger.Text; }
            set { Action(() => { lLogger.Text = value; }); }
        }
        public string Stats
        {
            get { return lSent.Text; }
            set { Action(() => { lSent.Text = value; }); }
        }

        public int Sleepiness { get; set; }
        public TimeSpan Timing { get; private set; }
        public DateTime Date { get; private set; }
        public bool Success { get; private set; }
        public bool Detailed
        {
            get { return lLogger.Visible; }
            set
            {
                Action(() =>
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
            GeneratorThread = new Thread(Run);
            NumberOfEventsDone = 0;
            Detailed = false;
        }

        public void Prepare()
        {
            if (-1 != Interlocked.CompareExchange(ref State, 0, -1)) return;

            var fixedLoggerName = String.IsNullOrEmpty(LoggerName) ? GetType().FullName : LoggerName;
            log = LogManager.GetLogger(fixedLoggerName);

            GeneratorThread.Name = this.Name;
            GeneratorThread.Start();

        }
        public void Start()
        {
            Date = DateTime.Now;
            Interlocked.CompareExchange(ref State, 1, 0);
        }

        public void Stop()
        {
            State = 2;
        }

        protected void Action(Action action)
        {
            if (!progBar.IsDisposed && progBar.InvokeRequired)
                progBar.Invoke(action);
            else
                action();
        }

        void Run()
        {
            var watch = new Stopwatch();

            try
            {
                Color = Color.DarkBlue;
                var c = NumberOfEvents;
                var sleep = Sleepiness;

                if (log.IsDebugEnabled) log.Debug("Ready");

                while (State == 0) Thread.Sleep(1);

                watch.Start();

                for (int i = 0; i < c; i++)
                {
                    if (State != 1) break;

                    NumberOfEventsDone = i + 1;

                    if (log.IsDebugEnabled) log.DebugFormat("Event #{0}", NumberOfEventsDone);

                    if (sleep >= 0) Thread.Sleep(sleep);
                }

                watch.Stop();
            }
            finally
            {
                State = 2;

                Timing = watch.Elapsed;

                if (NumberOfEvents != NumberOfEventsDone)
                {
                    NumberOfEvents = NumberOfEventsDone;
                    Color = Color.DarkRed;
                    Success = false;
                }
                else
                {
                    Color = Color.DarkGreen;
                    Success = true;
                }
                Stats = String.Format("Score:{2}. Sent {0:###,###,###} events in {1}.", NumberOfEventsDone, Timing, NumberOfEventsDone / Timing.TotalMilliseconds);

                if (log.IsDebugEnabled) log.Debug(Stats);
            }
        }

        private void lCaption_Click(object sender, EventArgs e)
        {
            Detailed = !Detailed;
        }





        public int Set { get; set; }
    }
}
