using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Ana_ekran : Form
    {
        public Ana_ekran()
        {
            InitializeComponent();

        }

        private void btn_bilet_Click(object sender, EventArgs e) // Biletler formuna geçiş yapar
        {
            Biletler fr = new Biletler();
            fr.Show();
            this.Hide();
           
        }

        private void guna2Button2_Click(object sender, EventArgs e) // Mısır ve içecek formuna geçiş yapar
        {
            Misir_icecek fr = new Misir_icecek();
            fr.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e) // Ödeme formuna geçiş yapar
        {
            Odeme fr = new Odeme();
            fr.Show();
            this.Hide();
        }

       
    }
}
