namespace Debugger
{
    partial class admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Debugger.testDataSet();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new Debugger.testDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new Debugger.testDataSetTableAdapters.adminTableAdapter();
            this.userTableAdapter = new Debugger.testDataSetTableAdapters.userTableAdapter();
            this.userBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet11 = new Debugger.testDataSet1();
            this.userTableAdapter1 = new Debugger.testDataSet1TableAdapters.userTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are logged in as: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "user";
            this.userBindingSource1.DataSource = this.testDataSetBindingSource;
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataMember = "user";
            this.userBindingSource2.DataSource = this.testDataSetBindingSource;
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "admin";
            this.adminBindingSource1.DataSource = this.testDataSetBindingSource;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.testDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource3
            // 
            this.userBindingSource3.DataMember = "user";
            this.userBindingSource3.DataSource = this.testDataSetBindingSource;
            // 
            // userBindingSource4
            // 
            this.userBindingSource4.DataMember = "user";
            this.userBindingSource4.DataSource = this.testDataSet11;
            // 
            // testDataSet11
            // 
            this.testDataSet11.DataSetName = "testDataSet1";
            this.testDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 205);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please enter the username you want to delete";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private testDataSet testDataSet1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private testDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private testDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private System.Windows.Forms.BindingSource userBindingSource3;
        private testDataSet1 testDataSet11;
        private System.Windows.Forms.BindingSource userBindingSource4;
        private testDataSet1TableAdapters.userTableAdapter userTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}