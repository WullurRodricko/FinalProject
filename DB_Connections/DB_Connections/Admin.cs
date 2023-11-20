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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void SupplyInput_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

            this.Hide();
        }

        private void StudentMenuInput_Click(object sender, EventArgs e)
        {
            StudentMenuInput frm = new StudentMenuInput();
            frm.Show();

            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();

            this.Hide();
        }
    }
}
