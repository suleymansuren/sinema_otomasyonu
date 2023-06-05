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
    public partial class Misir_icecek : Form
    {
        public Misir_icecek()
        {
            InitializeComponent();
        }
        

        private void kucuk_secim_CheckedChanged(object sender, EventArgs e) // Küçük boy mısır seçimi yapılıp yapılmadığını kontrol eder
        {
            if (kucuk_secim.Checked==true)
            {
                misir_kucuk_adet.Enabled = true;
            }
            else
            {
                misir_kucuk_adet.Clear();
                misir_kucuk_adet.Enabled = false;
            }
        }

        private void buyuk_secim_CheckedChanged(object sender, EventArgs e) // Büyük boy mısır seçimi yapılıp yapılmadığını kontrol eder
        {
            if (buyuk_secim.Checked == true)
            {
                misir_buyuk_adet.Enabled = true;
            }
            else
            {
                misir_buyuk_adet.Clear();
                misir_buyuk_adet.Enabled = false;
            }
        }

        private void kova_secim_CheckedChanged(object sender, EventArgs e) // Kova boy mısır seçimi yapılıp yapılmadığını kontrol eder
        {
            if (kova_secim.Checked == true)
            {
                misir_kova_adet.Enabled = true;
            }
            else
            {
                misir_kova_adet.Clear();
                misir_kova_adet.Enabled = false;
            }
        }

        private void kola_CheckedChanged(object sender, EventArgs e) // Kola seçimi yapılıp yapılmadığını kontrol eder
        {
            if (kola_secim.Checked == true)
            {
                kola_adet.Enabled = true;
            }
            else
            {
                kola_adet.Clear();
                kola_adet.Enabled = false;
            }
        }

        private void soda_CheckedChanged(object sender, EventArgs e) // Soda seçimi yapılıp yapılmadığını kontrol eder
        {
            if (soda_secim.Checked == true)
            {
                soda_adet.Enabled = true;
            }
            else
            {
                soda_adet.Clear();
                soda_adet.Enabled = false;
            }
        }

        private void su_CheckedChanged(object sender, EventArgs e) // Su seçimi yapılıp yapılmadığını kontrol eder
        {
            if (su_secim.Checked == true)
            {
                su_adet.Enabled = true;
            }
            else
            {
                su_adet.Clear();
                su_adet.Enabled = false;
            }
        }


        public static string misir_veri = ""; // Farklı forma aktarılmak üzere bu formdaki toplam tutarı saklar
        private void misir_onay_Click(object sender, EventArgs e) // Yapılan seçimleri onaylamak ve ödeme kısmına aktarmak için kullanılır
        {
            int kucuk = 0, buyuk = 0, kova = 0;   // Mısırların boylarına göre fiyat tanımlaması
            if (misir_kucuk_adet.Text != "" && kucuk_secim.Checked == true) // Fiyat hesaplanma işlemleri yapılır.
            {
                kucuk = Convert.ToInt32(misir_kucuk_adet.Text);
                kucuk = kucuk * 20;
            }

            if (misir_buyuk_adet.Text != "" && buyuk_secim.Checked == true)
            {
                buyuk = Convert.ToInt32(misir_buyuk_adet.Text);
                buyuk = buyuk * 25;
            }

            if (misir_kova_adet.Text != "" && kova_secim.Checked == true)
            {
                kova = Convert.ToInt32(misir_kova_adet.Text);
                kova = kova * 28;
            }

            int kola = 0, soda = 0, su = 0;
            if (kola_adet.Text != "" && kola_secim.Checked == true)
            {
                kola = Convert.ToInt32(kola_adet.Text);
                kola = kola * 12;
            }
            if (soda_adet.Text != "" && soda_secim.Checked == true)
            {
                soda = Convert.ToInt32(soda_adet.Text);
                soda = soda * 10;
            }
            if (su_adet.Text != "" && su_secim.Checked == true)
            {
                su = Convert.ToInt32(su_adet.Text);
                su = su * 8;
            }
            if ((kola_adet.Text == "" && kola_secim.Checked == true) || (soda_adet.Text == "" && soda_secim.Checked == true) || (su_adet.Text == "" && su_secim.Checked == true) ||
                (misir_kucuk_adet.Text == "" && kucuk_secim.Checked == true) || (misir_buyuk_adet.Text == "" && buyuk_secim.Checked == true) || (misir_kova_adet.Text == "" && kova_secim.Checked == true))
            {
                MessageBox.Show("Lütfen tüm ürünlerin adetlerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("İşleminzi onaylandı ödeme yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            araToplam(kucuk, buyuk, kova, kola, soda, su);

        }

        private static void araToplam(int kucuk, int buyuk, int kova, int kola, int soda, int su) // Ara toplamı mısır veriye aktarır.
        {
            int ara_toplam = kucuk + buyuk + kova + kola + soda + su;
            misir_veri = ara_toplam.ToString();
        }

        void rakam_kontrol(object sender, KeyPressEventArgs e) // Girdinin rakam olup olmadığını kontrol eden fonksiyon
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void misir_kucuk_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender,e);
        }

        private void misir_buyuk_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender, e);
        }

        private void misir_kova_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender, e);
        }

        private void kola_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender, e);
        }

        private void soda_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender, e);
        }

        private void su_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender, e);
        }

        private void btn_bilet_Click(object sender, EventArgs e) // Bilet formuna geçiş yapar
        {
            Biletler fr = new Biletler();
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
