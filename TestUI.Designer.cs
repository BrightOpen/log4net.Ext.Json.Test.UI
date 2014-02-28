namespace log4net.Json.Test.UI
{
    partial class TestUI
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("aaa");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("bbb");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bGenerate = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bConfig = new System.Windows.Forms.Button();
            this.bFollow = new System.Windows.Forms.Button();
            this.tvDetail = new System.Windows.Forms.TreeView();
            this.timerPickEvents = new System.Windows.Forms.Timer(this.components);
            this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAppender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLogger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCount = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvLogs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.lCount);
            this.splitContainer1.Panel2.Controls.Add(this.bGenerate);
            this.splitContainer1.Panel2.Controls.Add(this.bClear);
            this.splitContainer1.Panel2.Controls.Add(this.bConfig);
            this.splitContainer1.Panel2.Controls.Add(this.bFollow);
            this.splitContainer1.Size = new System.Drawing.Size(585, 385);
            this.splitContainer1.SplitterDistance = 124;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbEntry
            // 
            this.tbEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEntry.Location = new System.Drawing.Point(3, 3);
            this.tbEntry.Multiline = true;
            this.tbEntry.Name = "tbEntry";
            this.tbEntry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEntry.Size = new System.Drawing.Size(492, 119);
            this.tbEntry.TabIndex = 1;
            this.tbEntry.Text = "Full text";
            // 
            // lvLogs
            // 
            this.lvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colLevel,
            this.colLogger,
            this.colThread,
            this.colMessage,
            this.colAppender});
            this.lvLogs.FullRowSelect = true;
            this.lvLogs.GridLines = true;
            this.lvLogs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLogs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvLogs.Location = new System.Drawing.Point(3, 3);
            this.lvLogs.MultiSelect = false;
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.ShowItemToolTips = true;
            this.lvLogs.Size = new System.Drawing.Size(579, 118);
            this.lvLogs.TabIndex = 0;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            this.lvLogs.SelectedIndexChanged += new System.EventHandler(this.lvLogs_SelectedIndexChanged);
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 118;
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(3, 90);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(75, 23);
            this.bGenerate.TabIndex = 21;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(3, 32);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bConfig
            // 
            this.bConfig.Location = new System.Drawing.Point(3, 61);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(75, 23);
            this.bConfig.TabIndex = 2;
            this.bConfig.Text = "Config";
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // bFollow
            // 
            this.bFollow.Location = new System.Drawing.Point(3, 3);
            this.bFollow.Name = "bFollow";
            this.bFollow.Size = new System.Drawing.Size(75, 23);
            this.bFollow.TabIndex = 0;
            this.bFollow.Text = "Follow";
            this.bFollow.UseVisualStyleBackColor = true;
            this.bFollow.Click += new System.EventHandler(this.bFollow_Click);
            // 
            // tvDetail
            // 
            this.tvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDetail.Location = new System.Drawing.Point(3, 3);
            this.tvDetail.Name = "tvDetail";
            this.tvDetail.Size = new System.Drawing.Size(492, 116);
            this.tvDetail.TabIndex = 20;
            // 
            // timerPickEvents
            // 
            this.timerPickEvents.Interval = 500;
            this.timerPickEvents.Tick += new System.EventHandler(this.timerPickEvents_Tick);
            // 
            // colMessage
            // 
            this.colMessage.Text = "Message";
            this.colMessage.Width = 76;
            // 
            // colAppender
            // 
            this.colAppender.Text = "TestAppender";
            this.colAppender.Width = 88;
            // 
            // colLevel
            // 
            this.colLevel.Text = "Level";
            this.colLevel.Width = 59;
            // 
            // colLogger
            // 
            this.colLogger.Text = "Logger";
            this.colLogger.Width = 112;
            // 
            // colThread
            // 
            this.colThread.Text = "Thread";
            this.colThread.Width = 89;
            // 
            // lCount
            // 
            this.lCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount.Location = new System.Drawing.Point(4, 120);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(77, 131);
            this.lCount.TabIndex = 22;
            this.lCount.Text = "0";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(84, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbEntry);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tvDetail);
            this.splitContainer2.Size = new System.Drawing.Size(498, 251);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 23;
            // 
            // TestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 409);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestUI";
            this.Text = "TestUI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDetail;
        private System.Windows.Forms.Button bFollow;
        private System.Windows.Forms.Button bConfig;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.TextBox tbEntry;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.Timer timerPickEvents;
        private System.Windows.Forms.ColumnHeader colLevel;
        private System.Windows.Forms.ColumnHeader colMessage;
        private System.Windows.Forms.ColumnHeader colAppender;
        private System.Windows.Forms.ColumnHeader colLogger;
        private System.Windows.Forms.ColumnHeader colThread;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lCount;
    }
}

