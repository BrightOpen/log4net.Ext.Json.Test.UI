namespace log4net.Json.Test.UI
{
    partial class Receive
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
            this.components = new System.ComponentModel.Container();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bStartStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lCallsWaiting = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.lCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWaitingCalls = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSleepiness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lCallsExecuting = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lCallsAvailable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitingCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepiness)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPort
            // 
            this.nudPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPort.Location = new System.Drawing.Point(89, 11);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(109, 20);
            this.nudPort.TabIndex = 0;
            this.nudPort.Value = new decimal(new int[] {
            55555,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // bStartStop
            // 
            this.bStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStartStop.Location = new System.Drawing.Point(12, 207);
            this.bStartStop.Name = "bStartStop";
            this.bStartStop.Size = new System.Drawing.Size(186, 41);
            this.bStartStop.TabIndex = 2;
            this.bStartStop.Text = "Start";
            this.bStartStop.UseVisualStyleBackColor = true;
            this.bStartStop.Click += new System.EventHandler(this.bStartStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calls waiting:";
            // 
            // lCallsWaiting
            // 
            this.lCallsWaiting.AutoSize = true;
            this.lCallsWaiting.Location = new System.Drawing.Point(102, 133);
            this.lCallsWaiting.Name = "lCallsWaiting";
            this.lCallsWaiting.Size = new System.Drawing.Size(13, 13);
            this.lCallsWaiting.TabIndex = 5;
            this.lCallsWaiting.Text = "0";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 1000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(102, 168);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(13, 13);
            this.lCount.TabIndex = 7;
            this.lCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Events received:";
            // 
            // nudWaitingCalls
            // 
            this.nudWaitingCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWaitingCalls.Location = new System.Drawing.Point(89, 37);
            this.nudWaitingCalls.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudWaitingCalls.Name = "nudWaitingCalls";
            this.nudWaitingCalls.Size = new System.Drawing.Size(109, 20);
            this.nudWaitingCalls.TabIndex = 8;
            this.nudWaitingCalls.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Expected calls";
            // 
            // nudSleepiness
            // 
            this.nudSleepiness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSleepiness.Location = new System.Drawing.Point(89, 63);
            this.nudSleepiness.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSleepiness.Name = "nudSleepiness";
            this.nudSleepiness.Size = new System.Drawing.Size(109, 20);
            this.nudSleepiness.TabIndex = 10;
            this.nudSleepiness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sleepiness";
            // 
            // lCallsExecuting
            // 
            this.lCallsExecuting.AutoSize = true;
            this.lCallsExecuting.Location = new System.Drawing.Point(102, 120);
            this.lCallsExecuting.Name = "lCallsExecuting";
            this.lCallsExecuting.Size = new System.Drawing.Size(13, 13);
            this.lCallsExecuting.TabIndex = 13;
            this.lCallsExecuting.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Calls executing";
            // 
            // lCallsAvailable
            // 
            this.lCallsAvailable.AutoSize = true;
            this.lCallsAvailable.Location = new System.Drawing.Point(102, 146);
            this.lCallsAvailable.Name = "lCallsAvailable";
            this.lCallsAvailable.Size = new System.Drawing.Size(13, 13);
            this.lCallsAvailable.TabIndex = 15;
            this.lCallsAvailable.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Calls available:";
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(151, 98);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(47, 13);
            this.lStatus.TabIndex = 16;
            this.lStatus.Text = "Stopped";
            // 
            // Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(210, 260);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lCallsAvailable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lCallsExecuting);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudSleepiness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudWaitingCalls);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lCallsWaiting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bStartStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPort);
            this.Name = "Receive";
            this.Text = "TestUI - Receive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Receive_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitingCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepiness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStartStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lCallsWaiting;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudWaitingCalls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSleepiness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lCallsExecuting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lCallsAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lStatus;
    }
}