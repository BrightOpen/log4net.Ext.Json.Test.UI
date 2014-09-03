namespace log4net.Json.Test.UI
{
    partial class BenchRun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lLogger = new System.Windows.Forms.Label();
            this.lSent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progBar
            // 
            this.progBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progBar.ForeColor = System.Drawing.Color.Cyan;
            this.progBar.Location = new System.Drawing.Point(49, 3);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(134, 14);
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBar.TabIndex = 1;
            this.progBar.Value = 50;
            // 
            // lCaption
            // 
            this.lCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lCaption.AutoEllipsis = true;
            this.lCaption.AutoSize = true;
            this.lCaption.BackColor = System.Drawing.Color.Transparent;
            this.lCaption.Location = new System.Drawing.Point(3, 0);
            this.lCaption.Name = "lCaption";
            this.lCaption.Size = new System.Drawing.Size(40, 20);
            this.lCaption.TabIndex = 2;
            this.lCaption.Text = "Item";
            this.lCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lCaption.Click += new System.EventHandler(this.lCaption_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lLogger, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lSent, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 122);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logger";
            // 
            // lLogger
            // 
            this.lLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLogger.Location = new System.Drawing.Point(49, 20);
            this.lLogger.Name = "lLogger";
            this.lLogger.Size = new System.Drawing.Size(134, 20);
            this.lLogger.TabIndex = 4;
            this.lLogger.Text = "BenchRun";
            // 
            // lSent
            // 
            this.lSent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSent.Location = new System.Drawing.Point(49, 40);
            this.lSent.Name = "lSent";
            this.lSent.Size = new System.Drawing.Size(134, 20);
            this.lSent.TabIndex = 6;
            this.lSent.Text = "0 sas asdas asd asd asd asd asd as as";
            // 
            // BenchRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BenchRun";
            this.Size = new System.Drawing.Size(186, 122);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label lCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lLogger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lSent;
    }
}
