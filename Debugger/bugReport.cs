using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debugger
{
    public partial class bugReport : Form
    {
        SqlConnection mySqlConnection;
        public bugReport(string user)
        {
            InitializeComponent();
            label4.Text = user;
        }
        /// <summary>
        /// enter the data into the bug report database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportBugButton_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");
                mySqlConnection.Open();

                String report = ("INSERT INTO [errors] ([user], error, description, code, date) VALUES (@user, @error, @description, @code, @date)"); //inserts into database
                SqlCommand reportCommand = new SqlCommand(report, mySqlConnection);
                reportCommand.Parameters.AddWithValue("@user", label4.Text);
                reportCommand.Parameters.AddWithValue("@error", textBox1.Text);
                reportCommand.Parameters.AddWithValue("@description", textBox2.Text);
                reportCommand.Parameters.AddWithValue("@code", richTextBox1.Text);
                reportCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy hh:mmtt"));
                reportCommand.ExecuteNonQuery();

                MessageBox.Show("Error Code " + textBox1.Text + " has been added to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }
        }

    }
}
