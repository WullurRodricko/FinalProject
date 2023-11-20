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
    public partial class StudentMenuInput : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public StudentMenuInput()
        {
            alamat = "server=localhost; database=visual_programming; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }
        private void StudentMenu_Load(object sender, EventArgs e)
        {
           

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void backbutton_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.Show();

            this.Hide();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("update makanan_mahasiswa set hari = '{0}', waktu = '{1}', nama_makanan = '{2}',  where FoodID ='{3}'", CBDay.Text, CBDay.Text, textFood.Text, textFoodID);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from makanan_mahasiswa where foodID ='{0}'", textFoodID.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                StudentMenu_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from makanan_mahasiswa where foodID ='{0}'", textFoodID.Text);
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
                        CBDay.Text = kolom["Hari"].ToString();
                        CBTime.Text = kolom["Waktu"].ToString();
                        textFood.Text = kolom["Nama Makanan"].ToString();
                        

                        updatebutton.Enabled = true;
                        deletebutton.Enabled = true;

                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                    StudentMenu_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            try
            {
                StudentMenu_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentMenu_Load_1(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from makanan_mahasiswa");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[0].HeaderText = "Food ID";
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[1].HeaderText = "Hari";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[2].HeaderText = "Waktu";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Nama Makanan";

                textFoodID.Clear();
                textFood.Clear();

                updatebutton.Enabled = false;
                searchbutton.Enabled = false;

                CBDay.Text = "-";
                CBTime.Text = "-";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {

                query = string.Format("insert into makanan_mahasiswa (Hari, Waktu, Nama_makanan) values ('{0}', '{1}', '{2}')", CBDay.Text, CBTime.Text, textFood.Text);
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    StudentMenu_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Insert data gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
