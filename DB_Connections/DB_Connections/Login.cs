using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DB_Connections
{
    public partial class Login : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Login()
        {
            InitializeComponent();
            alamat = "server=localhost; database=visual_programming; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from db_student where username = '{0}'", TextUsername.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        string level;
                        level = kolom["level"].ToString();
                        sandi = kolom["password"].ToString();
                        if (sandi == TextPassword.Text)
                        {
                            if (level == "1")
                            {
                                Admin frm = new Admin();
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                StudentPage frm = new StudentPage();
                                frm.Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            TextPassword.Clear();
                            MessageBox.Show("Password yang anda masukkan salah");

                        }
                    }

                }
                else
                {
                    TextUsername.Clear();
                    TextPassword.Clear();
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }









            /* if (TextUsername.Text == "admin" && (TextPassword.Text == "12345" || TextTempPassword.Text == "12345"))
            {
                Admin frm = new Admin();
                frm.Show();

                this.Hide();

                MessageBox.Show("Selamat Datang");
            }
            
            if (TextUsername.Text == "student" && (TextPassword.Text == "unklab12345" || TextTempPassword.Text == "unklab12345"))
            {
                Form3 frm = new Form3();
                frm.Show();

                this.Hide();

                MessageBox.Show("Selamat Datang");

            }
           
            else
            {
                TextUsername.Clear();
                TextPassword.Clear();
                MessageBox.Show("anda salah memasukkan username atau password"); 
            }*/

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBShowPassword.Checked == true)
            {
                TextTempPassword.Text = TextPassword.Text;
                TextTempPassword.Visible = true;
                TextPassword.Visible = false;

            }
            else
            {
                TextTempPassword.Visible = false;
                TextPassword.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
