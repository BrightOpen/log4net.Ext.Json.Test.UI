using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace log4net.Json.Test.UI
{
    public partial class Generate : Form
    {
        int sets;

        public Generate()
        {
            InitializeComponent();

            Clear();
            UpdateLoggers();
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            Align();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            foreach (var benchRun in flowLayoutPanel1.Controls.OfType<BenchRun>())
            {
                if (benchRun.Ready)
                    benchRun.Start();
            }
        }

        private void bPrepare_Click(object sender, EventArgs e)
        {
            sets++;
            var noEvents = (int)nudEvents.Value;
            var noThreads = (int)nudThreads.Value;
            var sleepiness = (int)nudSleepiness.Value;
            var loggerName = comboLoggerName.Text;
            var controls = new Control[noThreads];
            if (String.IsNullOrEmpty(loggerName)) loggerName = "BenchMark.Run{0}";

            var benchRun = new BenchRun()
            {
                Name = String.Format("BenchRun{0}", flowLayoutPanel1.Controls.Count, noEvents),
                LoggerName = String.Format(loggerName, flowLayoutPanel1.Controls.Count),
                EventsPerThread = noEvents,
                NumberOfThreads = noThreads,
                Sleepiness = sleepiness,
                Set = sets,
            };
            benchRun.Prepare();

            flowLayoutPanel1.Controls.Add(benchRun);
            flowLayoutPanel1.Controls.SetChildIndex(benchRun, 0);
            Align();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            sets = 0;
            Clear();
        }

        void Clear()
        {
            flowLayoutPanel1.SuspendLayout();
            foreach (var benchRun in flowLayoutPanel1.Controls.OfType<BenchRun>().ToArray())
            {
                if (!benchRun.Started)
                    flowLayoutPanel1.Controls.Remove(benchRun);

                benchRun.Dispose();
            }
            flowLayoutPanel1.ResumeLayout();
        }

        void Align()
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
                ctrl.Width = flowLayoutPanel1.Width - 30;
        }
        void Stop()
        {
            foreach (var benchRun in flowLayoutPanel1.Controls.OfType<BenchRun>())
            {
                benchRun.Stop();
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Generate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            sb.AppendLine("Date,Name,Duration,Events,Sleepiness,Logger,Set");

            foreach (var benchRun in flowLayoutPanel1.Controls.OfType<BenchRun>())
            {
                sb.AppendFormat(@"{0},""{1}"",{2},{3},{4},""{5}"",{6}"
                    , benchRun.Date.ToString("yyyy-MM-dd hh:mm:ss")
                    , benchRun.Name.Replace(@"""", @"""""")
                    , benchRun.Timing.TotalMilliseconds
                    , benchRun.NumberOfEventsDone
                    , benchRun.Sleepiness
                    , benchRun.LoggerName.Replace(@"""", @"""""")
                    , benchRun.Set
                    );
                sb.AppendLine();
            }

            Clipboard.SetText(sb.ToString());
            MessageBox.Show("Report has been placed in the clipboard as CSV");
        }

        private void bLoadLoggers_Click(object sender, EventArgs e)
        {
            UpdateLoggers();
        }

        private void UpdateLoggers()
        {
            var repo = LogManager.GetRepository();
            var loggers = repo.GetCurrentLoggers();
            comboLoggerName.Items.Clear();
            comboLoggerName.Items.AddRange(
                            loggers
                            .Select(l => l.Name + ".Run{0}")
                            .Where(n => n.StartsWith("BenchMark."))
                            .OrderBy(n => n)
                            .ToArray()
                             );
        }

    }
}
