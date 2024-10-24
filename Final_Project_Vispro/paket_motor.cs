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
    public partial class paket_motor : Form
    {
        public paket_motor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            services services = new services();
            services.Show();
            this.Hide();
        }
    }
}
