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
        public Generate()
        {
            InitializeComponent();

            Clear();
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
            var noEvents = (int)nudEvents.Value;
            var noThreads = (int)nudThreads.Value;
            var sleepiness = (int)nudSleepiness.Value;
            var loggerName = tbLoggerName.Text;
            if (String.IsNullOrEmpty(loggerName)) loggerName = "BenchMark.Run{0}";
            for (int i = 0; i < noThreads; i++)
            {
                var benchRun = new BenchRun()
                {
                    Name = String.Format("BenchRun{0}", flowLayoutPanel1.Controls.Count, noEvents),
                    Caption = String.Format("#{0}: {1} events", flowLayoutPanel1.Controls.Count, noEvents),
                    LoggerName = String.Format(loggerName, flowLayoutPanel1.Controls.Count),
                    NumberOfEvents = noEvents,
                    Sleepiness = sleepiness,
                };
                flowLayoutPanel1.Controls.Add(benchRun);
                flowLayoutPanel1.Controls.SetChildIndex(benchRun, 0);
                benchRun.Prepare();
            }

            Align();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            foreach (var benchRun in flowLayoutPanel1.Controls.OfType<BenchRun>().ToArray())
            {
                if (!benchRun.Started)
                    flowLayoutPanel1.Controls.Remove(benchRun);
            }
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

    }
}
