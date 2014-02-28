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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("aaa");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("bbb");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bClear = new System.Windows.Forms.Button();
            this.bConfig = new System.Windows.Forms.Button();
            this.bFollow = new System.Windows.Forms.Button();
            this.tvDetail = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tbEntry);
            this.splitContainer1.Panel1.Controls.Add(this.lvLogs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bClear);
            this.splitContainer1.Panel2.Controls.Add(this.bConfig);
            this.splitContainer1.Panel2.Controls.Add(this.bFollow);
            this.splitContainer1.Panel2.Controls.Add(this.tvDetail);
            this.splitContainer1.Size = new System.Drawing.Size(585, 385);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbEntry
            // 
            this.tbEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEntry.Location = new System.Drawing.Point(3, 140);
            this.tbEntry.Multiline = true;
            this.tbEntry.Name = "tbEntry";
            this.tbEntry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEntry.Size = new System.Drawing.Size(579, 83);
            this.tbEntry.TabIndex = 1;
            this.tbEntry.Text = "Full text";
            // 
            // lvLogs
            // 
            this.lvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1});
            this.lvLogs.FullRowSelect = true;
            this.lvLogs.GridLines = true;
            this.lvLogs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvLogs.Location = new System.Drawing.Point(3, 3);
            this.lvLogs.MultiSelect = false;
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.ShowItemToolTips = true;
            this.lvLogs.Size = new System.Drawing.Size(579, 131);
            this.lvLogs.TabIndex = 0;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            this.lvLogs.SelectedIndexChanged += new System.EventHandler(this.lvLogs_SelectedIndexChanged);
            // 
            // col1
            // 
            this.col1.Text = "Log entry";
            this.col1.Width = 100;
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
            this.tvDetail.Location = new System.Drawing.Point(84, 3);
            this.tvDetail.Name = "tvDetail";
            this.tvDetail.Size = new System.Drawing.Size(498, 149);
            this.tvDetail.TabIndex = 20;
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
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader col1;
    }
}

