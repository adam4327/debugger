using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data.OleDb;

namespace Debugger
{
    /// <summary>
    /// Login form
    /// </summary>
    public partial class form1 : Form
    {
        SqlConnection mySqlConnection;
        /// <summary>
        /// Initialize component
        /// </summary>
        public form1()
        {
            String[] myData = new String[100];
            InitializeComponent();

        }
        /// <summary>
        /// Exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Exit button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Login to the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Login button
        private void Login_Click(object sender, EventArgs e)
        {

            try
            {
                mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");
                
                mySqlConnection.Open();
                //adminInstance Instance = true;
                String admin = ("SELECT * FROM [admin] WHERE username='" + textBox1.Text + "' AND [password]='" + textBox2.Text + "'");
                SqlCommand adminCommand = new SqlCommand(admin, mySqlConnection);
                SqlDataReader mySqlDataReader = adminCommand.ExecuteReader();


                // if admin logs in go to admin page
                if (mySqlDataReader.Read() == true)
                {
                    //MessageBox.Show("You have signed in as " + textBox1.Text);
                    mySqlDataReader.Close();
                    this.Hide();
                    admin adminPage = new admin(textBox1.Text);
                    adminPage.ShowDialog();

                }
                // if user go to user page
                else
                {
                    mySqlDataReader.Close();
                    String user = ("SELECT * FROM [user] WHERE username='" + textBox1.Text + "' AND [password]='" + textBox2.Text + "'");
                    SqlCommand userCommand = new SqlCommand(user, mySqlConnection);
                    SqlDataReader userReader = userCommand.ExecuteReader();

                    if (userReader.Read() == true)
                    {
                        this.Hide();
                        user userPage = new user(textBox1.Text);
                        userPage.ShowDialog();
                        //MessageBox.Show("logged in as " + textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }

                }

                       mySqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }


        }

        /// <summary>
        /// register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void register_Click(object sender, EventArgs e)
        {
            register registerPage = new register();
            registerPage.ShowDialog();
        }
    }

}



