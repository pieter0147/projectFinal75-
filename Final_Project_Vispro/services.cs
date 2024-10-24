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
        public services()
        {
            InitializeComponent();
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
    }
}
