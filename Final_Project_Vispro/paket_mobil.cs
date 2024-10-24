using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Vispro
{
    public partial class paket_mobil : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public paket_mobil()
        {
            alamat = "server=localhost; database=db_carwashh; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void paket_mobil_Load(object sender, EventArgs e)
        {
            try
            {
                using (var koneksi = new MySqlConnection(alamat))
                {
                    koneksi.Open();
                    query = "SELECT * FROM tbl_history";
                    using (var perintah = new MySqlCommand(query, koneksi))
                    {
                        adapter = new MySqlDataAdapter(perintah);
                        ds.Clear();
                        adapter.Fill(ds);
                    }

                    // Inisialisasi kontrol
                    txtDate.CustomFormat = "dd-MM-yyyy HH:mm";
                    txtLicensePlate.Clear();
                    txtCost.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPackage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLicensePlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            services services = new services();
            services.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicensePlate.Text))
            {
                MessageBox.Show("Data Tidak lengkap !!");
                return;
            }

            string query = "INSERT INTO tbl_history (date, license_plate, cost, package) VALUES (@date, @licensePlate, @cost, @package);";

            try
            {
                using (var koneksi = new MySqlConnection(alamat))
                {
                    koneksi.Open(); // Buka koneksi
                    using (var perintah = new MySqlCommand(query, koneksi))
                    {
                        perintah.Parameters.AddWithValue("@date", txtDate.Value);
                        perintah.Parameters.AddWithValue("@licensePlate", txtLicensePlate.Text);
                        perintah.Parameters.AddWithValue("@cost", txtCost.Text);
                        perintah.Parameters.AddWithValue("@package", txtPackage.Text);

                        int res = perintah.ExecuteNonQuery();
                        if (res == 1)
                        {
                            MessageBox.Show("Insert Data Suksess ...");
                            paket_mobil_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Gagal inser Data . . . ");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
