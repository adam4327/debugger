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
    public partial class search : Form
    {
        SqlConnection mySqlConnection;
        public search()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
/// <summary>
/// display the details after the search
/// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");

                mySqlConnection.Open();
                //search query % (anything before or after)
                String report = ("SELECT * FROM [errors] WHERE description LIKE '%" + textBox1.Text + "%' OR error LIKE '%" + textBox1.Text + "%' OR Id LIKE '%" + textBox1.Text + "%';");
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
        /// user can click on data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["Id"].Value);

                MessageBox.Show(a);

            }
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
        }

    }
}
