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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void onay_Click(object sender, EventArgs e) // Onayla butonuna basıldığında girdilerin boş olup olmadığını kontrol eder 
                                                            // Dolu lolması durumunda kartKontrol fonksiyonunu çağırır.
        {
            if(kart_no.Text == "" || cmb_ay.SelectedIndex==0 || cmb_yil.SelectedIndex==0 || kart_isim.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string kart_numarasi = kart_no.Text;
                bool sonuc = kartKontrol(kart_numarasi);
                if (sonuc == true)
                {
                    MessageBox.Show("Ödeme Başarıyla Alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    toplam_tutar.Text = "0 TL";
                }
                else
                {
                    MessageBox.Show("Kart Numarası Hatalı Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Temizle();
                }

            }


        }

        static bool kartKontrol(string kart_numarasi) // Luhn algoritması kullanarak kart numarasının geçerli olup olmadığını kontrol eder.
        {
            int toplam = 0;
            string kartNoTers = string.Empty;
            string sayilar = string.Empty;

            kart_numarasi = kart_numarasi.Replace(" ", null).Replace("-", null);

            for (int i = kart_numarasi.Length - 1; i >= 0; i--)
            {
                kartNoTers += kart_numarasi[i];
            }

            for (int i = 0; i < kartNoTers.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    sayilar += Convert.ToInt32(kartNoTers.Substring(i, 1)) * 2;
                }
                else
                {
                    sayilar += kartNoTers.Substring(i, 1);
                }
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += Convert.ToInt32(sayilar.Substring(i, 1));
            }

            if (toplam % 10 == 0)
            {
                return true;
            }
            return false;
        }

        void Temizle() // TextBox ları temizlemek için kullanılan fonksiyon
        {
            kart_no.Clear();
            cmb_ay.SelectedIndex = 0;
            cmb_yil.SelectedIndex = 0;
            kart_isim.Clear();
            cvv_text.Clear();
        }
        void rakam_kontrol(object sender, KeyPressEventArgs e) // Rakam kontrol fonksiyonu
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kart_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender, e);
        }

        private void btn_bilet_Click(object sender, EventArgs e) // Biletler formuna geçiş
        {
            Biletler fr = new Biletler();
            fr.Show();
            this.Hide();
        }

        private void btn_misir_Click(object sender, EventArgs e) // Mısırlar ve içecekler formuna geçiş
        {
            Misir_icecek fr = new Misir_icecek();
            fr.Show();
            this.Hide();
        }

        private void Odeme_Load(object sender, EventArgs e) // Form yüklenirken diğer formlardan alınan toplam tutarları ekrana yazdırır.
        {
            if (Biletler.bilet_veri != "")
            {
                int bilet_toplam = Convert.ToInt32(Biletler.bilet_veri);
                int misir_toplam = 0;
                if(Misir_icecek.misir_veri != "")
                {
                    misir_toplam = Convert.ToInt32(Misir_icecek.misir_veri);
                    toplam_tutar.Text = (bilet_toplam + misir_toplam).ToString() + " TL";
                }
               
                toplam_tutar.Text = (bilet_toplam + misir_toplam).ToString() + " TL";
            }
            else if(Misir_icecek.misir_veri != "")
            {
                int misir_toplam = Convert.ToInt32(Misir_icecek.misir_veri);
                toplam_tutar.Text = (misir_toplam).ToString() + " TL";
            }
            else
            {
                kart_no.Enabled = false;
                cmb_ay.Enabled = false;
                cmb_yil.Enabled = false;
                cvv_text.Enabled = false;
                kart_isim.Enabled = false;
                onay.Enabled = false;
                toplam_tutar.Visible = false;
            }
            
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            rakam_kontrol(sender, e);
        }
    }
}
