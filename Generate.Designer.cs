namespace log4net.Json.Test.UI
{
    partial class Generate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nudEvents = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.bPrepare = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoggerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSleepiness = new System.Windows.Forms.NumericUpDown();
            this.benchRun6 = new log4net.Json.Test.UI.BenchRun();
            this.lHelp = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepiness)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.benchRun6);
            this.flowLayoutPanel1.Controls.Add(this.lHelp);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 330);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nudSleepiness);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tbLoggerName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.bClear);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bPrepare);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nudThreads);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.nudEvents);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(664, 336);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 2;
            // 
            // nudEvents
            // 
            this.nudEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudEvents.Location = new System.Drawing.Point(101, 3);
            this.nudEvents.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudEvents.Name = "nudEvents";
            this.nudEvents.Size = new System.Drawing.Size(229, 20);
            this.nudEvents.TabIndex = 0;
            this.nudEvents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events per thread";
            // 
            // bStart
            // 
            this.bStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStart.Location = new System.Drawing.Point(3, 165);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(327, 52);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of threads";
            // 
            // nudThreads
            // 
            this.nudThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudThreads.Location = new System.Drawing.Point(101, 29);
            this.nudThreads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudThreads.Name = "nudThreads";
            this.nudThreads.Size = new System.Drawing.Size(229, 20);
            this.nudThreads.TabIndex = 1;
            this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bPrepare
            // 
            this.bPrepare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrepare.Location = new System.Drawing.Point(3, 107);
            this.bPrepare.Name = "bPrepare";
            this.bPrepare.Size = new System.Drawing.Size(327, 52);
            this.bPrepare.TabIndex = 4;
            this.bPrepare.Text = "Prepare";
            this.bPrepare.UseVisualStyleBackColor = true;
            this.bPrepare.Click += new System.EventHandler(this.bPrepare_Click);
            // 
            // bStop
            // 
            this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStop.Location = new System.Drawing.Point(3, 223);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(327, 52);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(3, 281);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(327, 52);
            this.bClear.TabIndex = 7;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sleepines [ms]";
            // 
            // tbLoggerName
            // 
            this.tbLoggerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoggerName.Location = new System.Drawing.Point(101, 81);
            this.tbLoggerName.Name = "tbLoggerName";
            this.tbLoggerName.Size = new System.Drawing.Size(229, 20);
            this.tbLoggerName.TabIndex = 3;
            this.tbLoggerName.Text = "BenchMark.Run{0}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logger name";
            // 
            // nudSleepiness
            // 
            this.nudSleepiness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepiness.Location = new System.Drawing.Point(101, 55);
            this.nudSleepiness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSleepiness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSleepiness.Name = "nudSleepiness";
            this.nudSleepiness.Size = new System.Drawing.Size(229, 20);
            this.nudSleepiness.TabIndex = 2;
            // 
            // benchRun6
            // 
            this.benchRun6.Caption = "BenchRun";
            this.benchRun6.Color = System.Drawing.SystemColors.ControlText;
            this.benchRun6.Location = new System.Drawing.Point(0, 0);
            this.benchRun6.LoggerName = null;
            this.benchRun6.Margin = new System.Windows.Forms.Padding(0);
            this.benchRun6.Name = "benchRun6";
            this.benchRun6.NumberOfEvents = 0;
            this.benchRun6.NumberOfEventsDone = 0;
            this.benchRun6.Size = new System.Drawing.Size(310, 23);
            this.benchRun6.Sleepiness = 0;
            this.benchRun6.Success = false;
            this.benchRun6.TabIndex = 5;
            this.benchRun6.TabStop = false;
            this.benchRun6.Timing = System.TimeSpan.Parse("00:00:00");
            // 
            // lHelp
            // 
            this.lHelp.AutoSize = true;
            this.lHelp.Location = new System.Drawing.Point(3, 23);
            this.lHelp.Name = "lHelp";
            this.lHelp.Size = new System.Drawing.Size(187, 26);
            this.lHelp.TabIndex = 6;
            this.lHelp.Text = "Set Sleepiness to -1 not to sleep at all.\r\n\r\n";
            // 
            // Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 360);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Generate";
            this.Text = "TestUI - Generate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generate_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepiness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BenchRun benchRun6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudThreads;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEvents;
        private System.Windows.Forms.Button bPrepare;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox tbLoggerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSleepiness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lHelp;
    }
}