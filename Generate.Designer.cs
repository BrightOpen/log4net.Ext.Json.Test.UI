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
            this.lHelp = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bReport = new System.Windows.Forms.Button();
            this.nudSleepiness = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bPrepare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.bStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEvents = new System.Windows.Forms.NumericUpDown();
            this.bLoadLoggers = new System.Windows.Forms.Button();
            this.comboLoggerName = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lHelp);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(416, 367);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // lHelp
            // 
            this.lHelp.AutoSize = true;
            this.lHelp.Location = new System.Drawing.Point(3, 3);
            this.lHelp.Margin = new System.Windows.Forms.Padding(3);
            this.lHelp.Name = "lHelp";
            this.lHelp.Padding = new System.Windows.Forms.Padding(10);
            this.lHelp.Size = new System.Drawing.Size(207, 46);
            this.lHelp.TabIndex = 6;
            this.lHelp.Text = "Set Sleepiness to -1 not to sleep at all.\r\n\r\n";
            this.lHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboLoggerName);
            this.splitContainer1.Panel1.Controls.Add(this.bLoadLoggers);
            this.splitContainer1.Panel1.Controls.Add(this.bReport);
            this.splitContainer1.Panel1.Controls.Add(this.nudSleepiness);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
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
            this.splitContainer1.Size = new System.Drawing.Size(756, 373);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 2;
            // 
            // bReport
            // 
            this.bReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bReport.Location = new System.Drawing.Point(3, 290);
            this.bReport.Name = "bReport";
            this.bReport.Size = new System.Drawing.Size(327, 37);
            this.bReport.TabIndex = 7;
            this.bReport.Text = "Report";
            this.bReport.UseVisualStyleBackColor = true;
            this.bReport.Click += new System.EventHandler(this.bReport_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logger name";
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
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(3, 333);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(327, 37);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bStop
            // 
            this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStop.Location = new System.Drawing.Point(3, 247);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(327, 37);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bPrepare
            // 
            this.bPrepare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrepare.Location = new System.Drawing.Point(3, 161);
            this.bPrepare.Name = "bPrepare";
            this.bPrepare.Size = new System.Drawing.Size(327, 37);
            this.bPrepare.TabIndex = 4;
            this.bPrepare.Text = "Prepare";
            this.bPrepare.UseVisualStyleBackColor = true;
            this.bPrepare.Click += new System.EventHandler(this.bPrepare_Click);
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
            // bStart
            // 
            this.bStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStart.Location = new System.Drawing.Point(3, 204);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(327, 37);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
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
            // bLoadLoggers
            // 
            this.bLoadLoggers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoadLoggers.Location = new System.Drawing.Point(3, 118);
            this.bLoadLoggers.Name = "bLoadLoggers";
            this.bLoadLoggers.Size = new System.Drawing.Size(327, 37);
            this.bLoadLoggers.TabIndex = 4;
            this.bLoadLoggers.Text = "Loggers";
            this.bLoadLoggers.UseVisualStyleBackColor = true;
            this.bLoadLoggers.Click += new System.EventHandler(this.bLoadLoggers_Click);
            // 
            // comboLoggerName
            // 
            this.comboLoggerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLoggerName.FormattingEnabled = true;
            this.comboLoggerName.Location = new System.Drawing.Point(101, 82);
            this.comboLoggerName.Name = "comboLoggerName";
            this.comboLoggerName.Size = new System.Drawing.Size(229, 21);
            this.comboLoggerName.TabIndex = 3;
            this.comboLoggerName.Text = "BenchMark.Run{0}";
            // 
            // Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 397);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudThreads;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEvents;
        private System.Windows.Forms.Button bPrepare;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSleepiness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lHelp;
        private System.Windows.Forms.Button bReport;
        private System.Windows.Forms.ComboBox comboLoggerName;
        private System.Windows.Forms.Button bLoadLoggers;
    }
}