using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Connections
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void universitasKlabatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMenu frm = new StudentMenu();
            frm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutUs frm = new AboutUs();
            frm.Show();

            this.Hide();
        }
    }
}
