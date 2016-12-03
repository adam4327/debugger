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
using Twilio;

    namespace Debugger
    {
        public partial class register : Form
        {
            SqlConnection mySqlConnection;
            public register()
            {
                InitializeComponent();
            }

            /// <summary>
            /// Create an account for the user and isert their details into the database
            /// send a sms to the admin that a new user has joined them
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True; MultipleActiveResultSets=true; Connect Timeout=30");
                    mySqlConnection.Open();

                

                    //add users details into the datbase
                    String register = ("INSERT INTO [user] ([username], [password]) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "')");
                    SqlCommand registerCommand = new SqlCommand(register, mySqlConnection);

                    string user = textBox1.Text;
                    string password = textBox2.Text;
                    string confirmPassword = textBox3.Text;

                        // validation check
                        if (password == confirmPassword)
                        {
                            registerCommand.ExecuteNonQuery();
                            MessageBox.Show("Successfully registered");


                        //send a sms message to the admin
                    

                            // set our AccountSid and AuthToken
                            string AccountSid = "AC4c462a98f9da8247b9a1ff5191ecee64";
                            string AuthToken = "781393134b6362d229f86a60c8369f35";

                            // instantiate a new Twilio Rest Client
                            var client = new TwilioRestClient(AccountSid, AuthToken);
                            //send message
                            var message = client.SendMessage("+441827230097", "+447808275497", user);

                        }
                        else
                        {
                            MessageBox.Show("Passwords did not match");
                        }

                

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed due to: " + ex.Message + textBox2.Text + textBox3.Text);
                }
            }
        }
    }
