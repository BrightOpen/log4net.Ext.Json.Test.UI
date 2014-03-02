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
    public partial class Receive : Form
    {
        LogUdpReceiver Receiver;

        public Receive()
        {
            InitializeComponent();
            timerStatus.Start();
            Flip();
        }

        private void bStartStop_Click(object sender, EventArgs e)
        {
            Flip();
        }

        void Flip()
        {
            var rcv = Receiver;

            if (rcv == null)
            {
                rcv = new LogUdpReceiver();
                rcv.Port = (int)nudPort.Value;
                rcv.ExpectedCalls = (int)nudWaitingCalls.Value;
                rcv.Sleepiness = (int)nudSleepiness.Value;
                rcv.Start();

                Receiver = rcv;
                bStartStop.Text = "Stop";
            }
            else
            {
                rcv.Stop();
                Receiver = null;
                bStartStop.Text = "Start";
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            var receiver = Receiver;
            if (receiver == null)
            {
                lStatus.Text = "Stopped";
                lStatus.ForeColor = SystemColors.ControlText;
            }
            else
            {
                lStatus.Text = receiver.IsAlive ? "Alive" : "Dead";
                lStatus.ForeColor = receiver.IsAlive ? Color.Green : Color.DarkRed;
                lCallsExecuting.Text = receiver.ExecutingCalls.ToString();
                lCallsWaiting.Text = receiver.WaitingCalls.ToString();
                lCallsAvailable.Text = receiver.AvailableCalls.ToString();
                lCount.Text = receiver.MessageCount.ToString();
            }
        }

        private void Receive_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Receiver != null)
            {
                Receiver.Stop();
                Receiver = null;
                bStartStop.Text = "Start";
            }
        }
    }
}
