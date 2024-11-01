using MySql.Data.MySqlClient;
using System;
using System.Collections;
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

namespace Final_Project_Vispro
{
    public partial class profile_employee : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private int id_user;
        public profile_employee(int param)
        {
            alamat = "server=localhost; database=db_carwashh; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
            id_user = param;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void profile_employee_Load(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_login where user_id = '{0}'", id_user);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {

                        txtName.Text = kolom["nama"].ToString();
                        txtPosisi.Text = kolom["posisi"].ToString();
                        txtUsername.Text = kolom["username"].ToString();
                        
                    }

                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
    }
}
