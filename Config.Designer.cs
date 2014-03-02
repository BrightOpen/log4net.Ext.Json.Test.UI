namespace log4net.Json.Test.UI
{
    partial class Config
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.tvRepos = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbAppender = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lAppenderType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAppenderThresholds = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbLogger = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lLoggerType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLoggerLevels = new System.Windows.Forms.ComboBox();
            this.bLoggerSave = new System.Windows.Forms.Button();
            this.gbRepo = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbRepoConfig = new System.Windows.Forms.TextBox();
            this.bSaveRepo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRepoMessages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbAppender.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbLogger.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbRepo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvRepos
            // 
            this.tvRepos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvRepos.Location = new System.Drawing.Point(3, 3);
            this.tvRepos.Name = "tvRepos";
            this.tvRepos.Size = new System.Drawing.Size(273, 481);
            this.tvRepos.TabIndex = 0;
            this.tvRepos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRepos_AfterSelect);
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
            this.splitContainer1.Panel1.Controls.Add(this.tvRepos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbAppender);
            this.splitContainer1.Panel2.Controls.Add(this.gbLogger);
            this.splitContainer1.Panel2.Controls.Add(this.gbRepo);
            this.splitContainer1.Size = new System.Drawing.Size(744, 487);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbAppender
            // 
            this.gbAppender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAppender.Controls.Add(this.tableLayoutPanel1);
            this.gbAppender.Location = new System.Drawing.Point(6, 215);
            this.gbAppender.Name = "gbAppender";
            this.gbAppender.Size = new System.Drawing.Size(213, 233);
            this.gbAppender.TabIndex = 2;
            this.gbAppender.TabStop = false;
            this.gbAppender.Text = "Appender";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lAppenderType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboAppenderThresholds, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bSave, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 208);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lAppenderType
            // 
            this.lAppenderType.AutoSize = true;
            this.lAppenderType.Location = new System.Drawing.Point(72, 0);
            this.lAppenderType.Name = "lAppenderType";
            this.lAppenderType.Size = new System.Drawing.Size(35, 13);
            this.lAppenderType.TabIndex = 0;
            this.lAppenderType.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // comboAppenderThresholds
            // 
            this.comboAppenderThresholds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAppenderThresholds.FormattingEnabled = true;
            this.comboAppenderThresholds.Location = new System.Drawing.Point(72, 16);
            this.comboAppenderThresholds.Name = "comboAppenderThresholds";
            this.comboAppenderThresholds.Size = new System.Drawing.Size(201, 21);
            this.comboAppenderThresholds.TabIndex = 6;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.bSave, 2);
            this.bSave.Location = new System.Drawing.Point(3, 142);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(270, 63);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Set";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Threshold";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbLogger
            // 
            this.gbLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogger.Controls.Add(this.tableLayoutPanel2);
            this.gbLogger.Location = new System.Drawing.Point(250, 215);
            this.gbLogger.Name = "gbLogger";
            this.gbLogger.Size = new System.Drawing.Size(182, 233);
            this.gbLogger.TabIndex = 1;
            this.gbLogger.TabStop = false;
            this.gbLogger.Text = "Logger";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lLoggerType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboLoggerLevels, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bLoggerSave, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 205);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lLoggerType
            // 
            this.lLoggerType.AutoSize = true;
            this.lLoggerType.Location = new System.Drawing.Point(47, 0);
            this.lLoggerType.Name = "lLoggerType";
            this.lLoggerType.Size = new System.Drawing.Size(35, 13);
            this.lLoggerType.TabIndex = 0;
            this.lLoggerType.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Level";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboLoggerLevels
            // 
            this.comboLoggerLevels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLoggerLevels.FormattingEnabled = true;
            this.comboLoggerLevels.Location = new System.Drawing.Point(47, 16);
            this.comboLoggerLevels.Name = "comboLoggerLevels";
            this.comboLoggerLevels.Size = new System.Drawing.Size(234, 21);
            this.comboLoggerLevels.TabIndex = 6;
            // 
            // bLoggerSave
            // 
            this.bLoggerSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.bLoggerSave, 2);
            this.bLoggerSave.Location = new System.Drawing.Point(3, 139);
            this.bLoggerSave.Name = "bLoggerSave";
            this.bLoggerSave.Size = new System.Drawing.Size(278, 63);
            this.bLoggerSave.TabIndex = 7;
            this.bLoggerSave.Text = "Set";
            this.bLoggerSave.UseVisualStyleBackColor = true;
            this.bLoggerSave.Click += new System.EventHandler(this.bLoggerSave_Click);
            // 
            // gbRepo
            // 
            this.gbRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRepo.Controls.Add(this.tabControl1);
            this.gbRepo.Location = new System.Drawing.Point(6, 3);
            this.gbRepo.Name = "gbRepo";
            this.gbRepo.Size = new System.Drawing.Size(375, 185);
            this.gbRepo.TabIndex = 0;
            this.gbRepo.TabStop = false;
            this.gbRepo.Text = "Repository";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 160);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbRepoConfig);
            this.tabPage1.Controls.Add(this.bSaveRepo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbRepoConfig
            // 
            this.tbRepoConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRepoConfig.Location = new System.Drawing.Point(2, 6);
            this.tbRepoConfig.Multiline = true;
            this.tbRepoConfig.Name = "tbRepoConfig";
            this.tbRepoConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRepoConfig.Size = new System.Drawing.Size(350, 56);
            this.tbRepoConfig.TabIndex = 0;
            this.tbRepoConfig.Text = resources.GetString("tbRepoConfig.Text");
            // 
            // bSaveRepo
            // 
            this.bSaveRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveRepo.Location = new System.Drawing.Point(0, 68);
            this.bSaveRepo.Name = "bSaveRepo";
            this.bSaveRepo.Size = new System.Drawing.Size(355, 66);
            this.bSaveRepo.TabIndex = 8;
            this.bSaveRepo.Text = "Set";
            this.bSaveRepo.UseVisualStyleBackColor = true;
            this.bSaveRepo.Click += new System.EventHandler(this.bSaveRepo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRepoMessages);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(355, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbRepoMessages
            // 
            this.tbRepoMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRepoMessages.Location = new System.Drawing.Point(6, 6);
            this.tbRepoMessages.Multiline = true;
            this.tbRepoMessages.Name = "tbRepoMessages";
            this.tbRepoMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRepoMessages.Size = new System.Drawing.Size(343, 125);
            this.tbRepoMessages.TabIndex = 0;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Config";
            this.Text = "TestUI - Config";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbAppender.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbLogger.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbRepo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }
        System.Windows.Forms.TextBox tbRepoMessages;
        System.Windows.Forms.TreeView tvRepos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbRepo;
        private System.Windows.Forms.GroupBox gbAppender;
        private System.Windows.Forms.GroupBox gbLogger;
        private System.Windows.Forms.Label lAppenderType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAppenderThresholds;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bSaveRepo;
        private System.Windows.Forms.TextBox tbRepoConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lLoggerType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboLoggerLevels;
        private System.Windows.Forms.Button bLoggerSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        
    }
}