using Sinema_Otomasyonu.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Sinema_Otomasyonu
{

    public partial class Biletler : Form
    {

        IDictionary<String, Movie> movies = new Dictionary<String, Movie>();

        public Biletler()
        {
            InitializeComponent();
        }
        ArrayList seciliKoltuklar = new ArrayList(); // Seçili koltukları tutan arraylist


        private void koltuklariKontrolEt()  // Koltukların seans ve filme göre durumunu kontrol eden fonksiyon
        {
            String index = cmb_filmler.SelectedIndex.ToString();
            String seansIndex = (cmb_seanslar.SelectedIndex).ToString();
            Movie secilenFilm = movies[index];
            
            if (secilenFilm != null)
            {
                for (int i = 0; i < 64; i++)
                {
                    if (!secilenFilm.data[seansIndex][i])
                    {
                        
                        if (i == 0)
                        {
                            a1.Enabled = false;
                        }
                        if (i == 1)
                        {
                            a2.Enabled = false;
                        }
                        if (i == 2)
                        {
                            a3.Enabled = false;
                        }
                        if (i == 3)
                        {
                            a4.Enabled = false;
                        }
                        if (i == 4)
                        {
                            a5.Enabled = false;
                        }
                        if (i == 5)
                        {
                            a6.Enabled = false;
                        }
                        if (i == 6)
                        {
                            a7.Enabled = false;
                        }
                        if (i == 7)
                        {
                            a8.Enabled = false;
                        }
                        if (i == 8)
                        {
                            b1.Enabled = false;
                        }
                        if (i == 9)
                        {
                            b2.Enabled = false;
                        }
                        if (i == 10)
                        {
                            b3.Enabled = false;
                        }
                        if (i == 11)
                        {
                            b4.Enabled = false;
                        }
                        if (i == 12)
                        {
                            b5.Enabled = false;
                        }
                        if (i == 13)
                        {
                            b6.Enabled = false;
                        }
                        if (i == 14)
                        {
                            b7.Enabled = false;
                        }
                        if (i == 15)
                        {
                            b8.Enabled = false;
                        }
                        if (i == 16)
                        {
                            c1.Enabled = false;
                        }
                        if (i == 17)
                        {
                            c2.Enabled = false;
                        }
                        if (i == 18)
                        {
                            c3.Enabled = false;
                        }
                        if (i == 19)
                        {
                            c4.Enabled = false;
                        }
                        if (i == 20)
                        {
                            c5.Enabled = false;
                        }
                        if (i == 21)
                        {
                            c6.Enabled = false;
                        }
                        if (i == 22)
                        {
                            c7.Enabled = false;
                        }
                        if (i == 23)
                        {
                            c8.Enabled = false;
                        }
                        if (i == 24)
                        {
                            d1.Enabled = false;
                        }
                        if (i == 25)
                        {
                            d2.Enabled = false;
                        }
                        if (i == 26)
                        {
                            d3.Enabled = false;
                        }
                        if (i == 27)
                        {
                            d4.Enabled = false;
                        }
                        if (i == 28)
                        {
                            d5.Enabled = false;
                        }
                        if (i == 29)
                        {
                            d6.Enabled = false;
                        }
                        if (i == 30)
                        {
                            d7.Enabled = false;
                        }
                        if (i == 31)
                        {
                            d8.Enabled = false;
                        }
                        if (i == 32)
                        {
                            e1.Enabled = false;
                        }
                        if (i == 33)
                        {
                            e2.Enabled = false;
                        }
                        if (i == 34)
                        {
                            e3.Enabled = false;
                        }
                        if (i == 35)
                        {
                            e4.Enabled = false;
                        }
                        if (i == 36)
                        {
                            e5.Enabled = false;
                        }
                        if (i == 37)
                        {
                            e6.Enabled = false;
                        }
                        if (i == 38)
                        {
                            e7.Enabled = false;
                        }
                        if (i == 39)
                        {
                            e8.Enabled = false;
                        }
                        if (i == 40)
                        {
                            f1.Enabled = false;
                        }
                        if (i == 41)
                        {
                            f2.Enabled = false;
                        }
                        if (i == 42)
                        {
                            f3.Enabled = false;
                        }
                        if (i == 43)
                        {
                            f4.Enabled = false;
                        }
                        if (i == 44)
                        {
                            f5.Enabled = false;
                        }
                        if (i == 45)
                        {
                            f6.Enabled = false;
                        }
                        if (i == 46)
                        {
                            f7.Enabled = false;
                        }
                        if (i == 47)
                        {
                            f8.Enabled = false;
                        }
                        if (i == 48)
                        {
                            g1.Enabled = false;
                        }
                        if (i == 49)
                        {
                            g2.Enabled = false;
                        }
                        if (i == 50)
                        {
                            g3.Enabled = false;
                        }
                        if (i == 51)
                        {
                            g4.Enabled = false;
                        }
                        if (i == 52)
                        {
                            g5.Enabled = false;
                        }
                        if (i == 53)
                        {
                            g6.Enabled = false;
                        }
                        if (i == 54)
                        {
                            g7.Enabled = false;
                        }
                        if (i == 55)
                        {
                            g8.Enabled = false;
                        }
                        if (i == 56)
                        {
                            h1.Enabled = false;
                        }
                        if (i == 57)
                        {
                            h2.Enabled = false;
                        }
                        if (i == 58)
                        {
                            h3.Enabled = false;
                        }
                        if (i == 59)
                        {
                            h4.Enabled = false;
                        }
                        if (i == 60)
                        {
                            h5.Enabled = false;
                        }
                        if (i == 61)
                        {
                            h6.Enabled = false;
                        }
                        if (i == 62)
                        {
                            h7.Enabled = false;
                        }
                        if (i == 63)
                        {
                            h8.Enabled = false;
                        }


                    }
                }
            }

        }

        private void koltuklariSifirla()
        {
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            a4.Enabled = true;
            a5.Enabled = true;
            a6.Enabled = true;
            a7.Enabled = true;
            a8.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;
            c4.Enabled = true;
            c5.Enabled = true;
            c6.Enabled = true;
            c7.Enabled = true;
            c8.Enabled = true;
            d1.Enabled = true;
            d2.Enabled = true;
            d3.Enabled = true;
            d4.Enabled = true;
            d5.Enabled = true;
            d6.Enabled = true;
            d7.Enabled = true;
            d8.Enabled = true;
            e1.Enabled = true;
            e2.Enabled = true;
            e3.Enabled = true;
            e4.Enabled = true;
            e5.Enabled = true;
            e6.Enabled = true;
            e7.Enabled = true;
            e8.Enabled = true;
            f1.Enabled = true;
            f2.Enabled = true;
            f3.Enabled = true;
            f4.Enabled = true;
            f5.Enabled = true;
            f6.Enabled = true;
            f7.Enabled = true;
            f8.Enabled = true;
            g1.Enabled = true;
            g2.Enabled = true;
            g3.Enabled = true;
            g4.Enabled = true;
            g5.Enabled = true;
            g6.Enabled = true;
            g7.Enabled = true;
            g8.Enabled = true;
            h1.Enabled = true;
            h2.Enabled = true;
            h3.Enabled = true;
            h4.Enabled = true;
            h5.Enabled = true;
            h6.Enabled = true;
            h7.Enabled = true;
            h8.Enabled = true;
        } // Seans ve film değişikliğinde koltukların durumunu sıfırlayan fonksiyon
        private void cmb_filmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_filmler.SelectedIndex == 0 || cmb_seanslar.SelectedIndex == 0)
            {
                guna2Panel3.Enabled = false;
            }
            else
            {
                guna2Panel3.Enabled = true;
            }
            seciliKoltuklar = new ArrayList();
            koltuklariSifirla();
            koltuklariKontrolEt();
            if(cmb_filmler.SelectedIndex == 0)
            {
                afis.ImageLocation = @"Filmler\default.jpg";
            }
            else if(cmb_filmler.SelectedIndex == 1)
            { 
                afis.ImageLocation = @"Filmler\shawshank_sunshine.jpg";
            }
            else if(cmb_filmler.SelectedIndex == 2)
            {
                afis.ImageLocation = @"Filmler\godfather.jpg";
            }
            else if(cmb_filmler.SelectedIndex == 3)
            {
                afis.ImageLocation = @"Filmler\dark_knight.jpg";
            }
            else if(cmb_filmler.SelectedIndex == 4)
            {
                afis.ImageLocation = @"Filmler\forest_gump.jpg";
            }
            else if (cmb_filmler.SelectedIndex == 5)
            {
                afis.ImageLocation = @"Filmler\fight_club.jpg";
            }
            else if (cmb_filmler.SelectedIndex == 6)
            {
                afis.ImageLocation = @"Filmler\inception.jpg";
            }
            else if (cmb_filmler.SelectedIndex == 7)
            {
                afis.ImageLocation = @"Filmler\interstellar.jpg";
            }
            else if (cmb_filmler.SelectedIndex == 8)
            {
                afis.ImageLocation = @"Filmler\pianist.jpg";
            }
            else if (cmb_filmler.SelectedIndex == 9)
            {
                afis.ImageLocation = @"Filmler\joker.jpg";
            }
            else if (cmb_filmler.SelectedIndex == 10)
            {
                afis.ImageLocation = @"Filmler\braveheart.jpg";
            }

        }// Film değişimine göre afişleri getirme işlemini yapar
        public int sayac = 0;
        private void a1_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(0);
            }
        } // Butona tıklandığında butonu rezerve eder sayacı arttırır ve seçili koltuklara ekler

        private void a2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(1);
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(2);
            }
        }

        private void a4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(3);
            }
        }

        private void a5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(4);
            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(5);
            }
        }

        private void a7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(6);
            }
        }

        private void a8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("A-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                a8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(7);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(8);
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(9);
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(10);
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(11);
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(12);
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(13);
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(14);
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("B-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                b8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(15);
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(16);
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(17);
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(18);
            }
        }

        private void c4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(19);
            }
        }

        private void c5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(20);
            }
        }

        private void c6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(21);
            }
        }

        private void c7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(22);
            }
        }

        private void c8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("C-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                c8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(23);
            }
        }

        private void d1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(24);
            }
        }

        private void d2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(25);
            }
        }

        private void d3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(26);
            }
        }

        private void d4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(27);
            }
        }

        private void d5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(28);
            }
        }

        private void d6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(29);
            }
        }

        private void d7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(30);
            }
        }

        private void d8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("D-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                d8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(31);
            }
        }

        private void e1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(32);
            }
        }

        private void e2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(33);
            }
        }

        private void e3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(34);
            }
        }

        private void e4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(35);
            }
        }

        private void e5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(36);
            }
        }

        private void e6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(37);
            }
        }

        private void e7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(38);
            }
        }

        private void e8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("E-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                e8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(39);
            }
        }

        private void f1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(40);
            }
        }

        private void f2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(41);
            }
        }

        private void f3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(42);
            }
        }

        private void f4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(43);
            }
        }

        private void f5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(44);
            }
        }

        private void f6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(45);
            }
        }

        private void f7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(46);
            }
        }

        private void f8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("F-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                f8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(47);
            }
        }

        private void g1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(48);
            }
        }

        private void g2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(49);
            }
        }

        private void g3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(50);
            }
        }

        private void g4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(51);
            }
        }

        private void g5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(52);
            }
        }

        private void g6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(53);
            }
        }

        private void g7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(54);
            }
        }

        private void g8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("G-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                g8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(55);
            }
        }

        private void h1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-1 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h1.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(56);
            }
        }

        private void h2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-2 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h2.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(57);
            }
        }

        private void h3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-3 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h3.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(58);
            }
        }

        private void h4_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-4 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h4.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(59);
            }
        }

        private void h5_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-5 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h5.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(60);
            }
        }

        private void h6_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-6 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h6.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(61);
            }
        }

        private void h7_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-7 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h7.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(62);
            }
        }

        private void h8_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("H-8 koltuğunu seçtiniz onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                h8.Enabled = false;
                sayac++;
                lbl_sayac.Text = sayac.ToString();
                this.secim.Checked = true;
                seciliKoltuklar.Add(63);
            }
        }

        

        

        private void guna2Button1_Click(object sender, EventArgs e) // Film seçimine göre fragman linkini getirir.
        {
            
            if (cmb_filmler.SelectedIndex == 0) 
            {
                MessageBox.Show("Lütfen Film Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cmb_filmler.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=7BG-BpvkYB8");
            }
            else if(cmb_filmler.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QV8OwaW8YsE");
            }
            else if (cmb_filmler.SelectedIndex == 3)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xl2NZ0Bt7yQ");
            }
            else if (cmb_filmler.SelectedIndex == 4)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NVOEolIqkVc");
            }
            else if (cmb_filmler.SelectedIndex == 5)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=SHH9UZlKid0");
            }
            else if (cmb_filmler.SelectedIndex == 6)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=CD2NyG_ApRQ");
            }
            else if (cmb_filmler.SelectedIndex == 7)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=vVJeYMRam0o");
            }
            else if (cmb_filmler.SelectedIndex == 8)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=jV_LxL_n4no");
            }
            else if (cmb_filmler.SelectedIndex == 9)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=WVC1KC4Lauc");
            }
            else if (cmb_filmler.SelectedIndex == 10)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=bnOHqdCJXt0");
            }

        }

        private void Biletler_Load(object sender, EventArgs e) // Form yüklenirken filmleri movies class'ına ekler
        {
            Movie esaretinBedeli = new Movie(1);
            Movie baba = new Movie(2);
            Movie karaSovalye = new Movie(3);
            Movie forestGump = new Movie(4);
            Movie dovusKulubu = new Movie(5);
            Movie baslangic = new Movie(6);
            Movie yildizlarArasinda = new Movie(7);
            Movie piyanist = new Movie(8);
            Movie joker = new Movie(9);
            Movie cesurYurek = new Movie(10);

            movies.Add("0",null);
            movies.Add("1", esaretinBedeli);
            movies.Add("2", baba);
            movies.Add("3", karaSovalye);
            movies.Add("4", forestGump);
            movies.Add("5", dovusKulubu);
            movies.Add("6", baslangic);
            movies.Add("7", yildizlarArasinda);
            movies.Add("8", piyanist);
            movies.Add("9", joker);
            movies.Add("10", cesurYurek);

            
        }

        private void cmb_seasnlar_SelectedIndexChanged(object sender, EventArgs e) // Seans değişimi sırasında seçim olup olmadığını kontrol eder ve 
                                                                                   // değişim olursa koltukların durumunu sıfırlar
        {
            if (cmb_filmler.SelectedIndex == 0 || cmb_seanslar.SelectedIndex == 0)
            {
                guna2Panel3.Enabled = false;
            }
            else
            {
                guna2Panel3.Enabled = true;
            }
            seciliKoltuklar = new ArrayList();
            koltuklariSifirla();
            koltuklariKontrolEt();
        }
        public static string bilet_veri = "";
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (cmb_filmler.SelectedIndex == 0 || cmb_seanslar.SelectedIndex == 0 || secim.Checked == false)
            {
                MessageBox.Show("Lütfen tüm seçimleri yaptınığızdan emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Seçimleriniz başarıyla alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String index = cmb_filmler.SelectedIndex.ToString();
                String seansIndex = cmb_seanslar.SelectedIndex.ToString();
                foreach (int i in seciliKoltuklar)
                {
                    movies[index].koltukKirala(seansIndex, i);
                }

                cmb_filmler.SelectedIndex = 0;
                cmb_seanslar.SelectedIndex = 0;
                afis.ImageLocation = @"Filmler\default.jpg";
                int bilet_toplam = Convert.ToInt32(lbl_sayac.Text);
                bilet_toplam = bilet_toplam*30;
                bilet_veri = bilet_toplam.ToString();
                
            }

        }
        

        private void btn_misir_Click(object sender, EventArgs e) // Mısır ve içecek formuna geçiş yapar
        {
            Misir_icecek fr = new Misir_icecek();
            fr.Show();
            this.Hide();
        }

        private void btn_icecek_Click(object sender, EventArgs e)
        {
            Odeme fr = new Odeme();
            fr.Show();
            this.Hide();
        }
        
    }
}
