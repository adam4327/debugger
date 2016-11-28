namespace Debugger
{
    partial class user
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bugReport = new System.Windows.Forms.Label();
            this.searchReport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(647, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(494, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "You are logged in as: ";
            // 
            // bugReport
            // 
            this.bugReport.AutoSize = true;
            this.bugReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bugReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bugReport.Location = new System.Drawing.Point(91, 252);
            this.bugReport.Name = "bugReport";
            this.bugReport.Size = new System.Drawing.Size(120, 24);
            this.bugReport.TabIndex = 4;
            this.bugReport.Text = "Report a Bug";
            this.bugReport.Click += new System.EventHandler(this.bugReport_Click);
            // 
            // searchReport
            // 
            this.searchReport.AutoSize = true;
            this.searchReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.searchReport.Location = new System.Drawing.Point(453, 252);
            this.searchReport.Name = "searchReport";
            this.searchReport.Size = new System.Drawing.Size(70, 24);
            this.searchReport.TabIndex = 5;
            this.searchReport.Text = "Search";
            this.searchReport.Click += new System.EventHandler(this.searchReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(278, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fix a Bug";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(730, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchReport);
            this.Controls.Add(this.bugReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "user";
            this.Text = "user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bugReport;
        private System.Windows.Forms.Label searchReport;
        private System.Windows.Forms.Label label3;
    }
}