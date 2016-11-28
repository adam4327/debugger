using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Debugger
{
    public partial class fixBug : Form
    {
        SqlConnection mySqlConnection;
        public fixBug(string user)
        {
            InitializeComponent();
            label5.Text = user;
        }

        /// <summary>
        /// creates a dropdown list of all the errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fixBug_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("select error from errors ORDER BY error ASC", mySqlConnection);

                SqlDataReader dr = cmd.ExecuteReader(); //reads query from database
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0]); //populates the combo box in an array of errors
                }
                dr.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }

        }

        /// <summary>
        /// Popluate the othe boxes on the page when the user has selected an error
        /// also populates anothe combo box to display different versions 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");
                mySqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [errors] WHERE error = '" + comboBox1.Text + "'", mySqlConnection);

                SqlDataReader dr = cmd.ExecuteReader();
                //set data into boxes from database
                while (dr.Read())
                {
                    string error = dr.GetString(2);
                    string description = dr.GetString(3);
                    string code = dr.GetString(4);
                    string username = dr.GetString(1);
                    string d = error.ToString();
                    textBox1.Text = d;
                    textBox2.Text = description;
                    richTextBox1.Text = code;
                    textBox3.Text = username;
                }

                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }

            //version combo box
            try
            {
                SqlCommand versionCMD = new SqlCommand("select date from fixedBugs WHERE error = '" + textBox1.Text + "' ORDER BY error ASC", mySqlConnection);

                SqlDataReader versionDR = versionCMD.ExecuteReader();
                while (versionDR.Read())
                {
                    comboBox2.Items.Add(versionDR[0]);
                }


                versionDR.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }

        }

        /// <summary>
        /// inserts the new data into the fixed bug database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportBugButton_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");
                mySqlConnection.Open();
                SqlCommand reportCommand = new SqlCommand("INSERT INTO[fixedBugs]([user], error, description, code, date, errorUser, errorLine, method, comments ) VALUES(@user, @error, @description, @code, @date, @errorUser, @errorLine, @method, @comments);", mySqlConnection); //inserts into database

                //Parameter Values
                reportCommand.Parameters.AddWithValue("@user", label5.Text);
                reportCommand.Parameters.AddWithValue("@error", textBox1.Text);
                reportCommand.Parameters.AddWithValue("@description", textBox2.Text);
                reportCommand.Parameters.AddWithValue("@code", richTextBox4.Text);
                reportCommand.Parameters.AddWithValue("@errorLine", textBox4.Text);
                reportCommand.Parameters.AddWithValue("@errorUser", textBox3.Text);
                reportCommand.Parameters.AddWithValue("@method", textBox5.Text);
                reportCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy hh:mmtt")); //inserts the time/date of upload
                reportCommand.Parameters.AddWithValue("@comments", richTextBox3.Text);
                reportCommand.ExecuteNonQuery();
                MessageBox.Show("The code has been Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }

        }

        /// <summary>
        /// Displays the version data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [fixedBugs] WHERE date = '" + comboBox2.Text + "'", mySqlConnection);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string error = dr.GetString(2);
                string description = dr.GetString(3);
                string code = dr.GetString(4);
                string username = dr.GetString(1);
                int i = 5;
                string d = error.ToString();
                textBox1.Text = d;
                textBox2.Text = description;
                richTextBox2.Text = code;
                textBox3.Text = username;
            }

            dr.Close();
            dr.Dispose();
        }

        /// <summary>
        /// Color coding - colors the code to make it easier fo rthe user to see
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // list of all the words that should change color
            string [] dataTypes = new string[] { "class", "int", "bool", "char", "float", "public", "private", "static", "void", "object", "while",
                                                 "using", "namespace", "foreach"};
            for (int i = 0; i < dataTypes.Length; i++)
            {
                Regex rx = new Regex(dataTypes[i]); // creates a new regualr expression
                int index = richTextBox2.SelectionStart;

                //loops through the dataTypes
                foreach (Match m in rx.Matches(richTextBox2.Text))
                {
                    richTextBox2.Select(m.Index, m.Value.Length);
                    richTextBox2.SelectionColor = Color.Blue;
                    richTextBox2.SelectionStart = index;
                    richTextBox2.SelectionColor = Color.Black;
                }
            }

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            // list of all the words that should change color
            string[] dataTypes = new string[] { "class", "int", "bool", "char", "float", "public", "private", "static", "void", "object", "while",
                                                 "using", "namespace", "foreach"};
            for (int i = 0; i < dataTypes.Length; i++)
            {
                Regex rx = new Regex(dataTypes[i]); // creates a new regualr expression
                int index = richTextBox4.SelectionStart;

                //loops through the dataTypes
                foreach (Match m in rx.Matches(richTextBox4.Text))
                {
                    richTextBox4.Select(m.Index, m.Value.Length);
                    richTextBox4.SelectionColor = Color.Blue;
                    richTextBox4.SelectionStart = index;
                    richTextBox4.SelectionColor = Color.Black;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // list of all the words that should change color
            string[] dataTypes = new string[] { "class", "int", "bool", "char", "float", "public", "private", "static", "void", "object", "while",
                                                 "using", "namespace", "foreach"};
            for (int i = 0; i < dataTypes.Length; i++)
            {
                Regex rx = new Regex(dataTypes[i]); // creates a new regualr expression
                int index = richTextBox1.SelectionStart;

                //loops through the dataTypes
                foreach (Match m in rx.Matches(richTextBox1.Text))
                {
                    richTextBox1.Select(m.Index, m.Value.Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.SelectionStart = index;
                    richTextBox1.SelectionColor = Color.Black;
                }
            }
        }
    }
}
