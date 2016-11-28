using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debugger
{
    public partial class user : Form
    {
        public user(string user)
        {
            InitializeComponent();
            label2.Text = user;
        }

        private void bugReport_Click(object sender, EventArgs e)
        {
            bugReport bugReportPage = new bugReport(label2.Text);
            bugReportPage.ShowDialog();
        }

        private void searchReport_Click(object sender, EventArgs e)
        {
            search searchReportPage = new search();
            searchReportPage.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fixBug fixBugPage = new fixBug(label2.Text);
            fixBugPage.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
