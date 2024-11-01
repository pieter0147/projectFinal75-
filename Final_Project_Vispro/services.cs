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
    public partial class services : Form
    {
        private int id_user;
        public services(int param)
        {
            InitializeComponent();
            id_user = param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paket_mobil paket_Mobil = new paket_mobil();
            paket_Mobil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paket_motor paket_Motor = new paket_motor();
            paket_Motor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sign_in_employe sign_In_Employe = new sign_in_employe();
            sign_In_Employe.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            profile_employee frmprof = new profile_employee(id_user);
            frmprof.Show();
            this.Hide();
        }
    }
}
