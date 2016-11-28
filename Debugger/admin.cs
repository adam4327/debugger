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
    /// <summary>
    /// 
    /// </summary>
    public partial class admin : Form
    {
        SqlConnection mySqlConnection;
        public admin(string admin)
        {
            InitializeComponent();
            label2.Text = admin; // sets label to admin


        }

        /// <summary>
        /// Deletes user specified by the admin, then the table is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");// new sql connection

                mySqlConnection.Open();
                String delete = ("DELETE FROM [user] WHERE username = '" + textBox1.Text + "'; "); // delete user on what the admin types in
                SqlCommand deleteCommand = new SqlCommand(delete, mySqlConnection);
                deleteCommand.ExecuteNonQuery();


                //refresh the table with the user deleted
                String report = ("SELECT * FROM [user]");
                SqlCommand reportCommand = new SqlCommand(report, mySqlConnection);
                reportCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(report, mySqlConnection);

                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }

        }

        /// <summary>
        /// load the table full of users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void admin_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");

                mySqlConnection.Open();
                String report = ("SELECT * FROM [user]"); // select all the users
                SqlCommand reportCommand = new SqlCommand(report, mySqlConnection);
                reportCommand.ExecuteNonQuery();

                DataTable dt = new DataTable(); // create new table
                SqlDataAdapter da = new SqlDataAdapter(report, mySqlConnection); //fills in the data

                // fill table
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message); // any errors are displayed in a message box
            }
        }
    
    }
}
