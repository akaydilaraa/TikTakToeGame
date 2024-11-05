using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TikTakToeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Yenile();
        }

        public enum Oyuncular
        {
            X, O
        }

        Oyuncular oyuncuX;
        int oyuncu = 0;
        int bilgisayar = 0;
        Random random = new Random();
        List<Button> Butonlar;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde başlangıç ayarları
        }

        private void OyuncuSure(object sender, EventArgs e)
        {
            if (Butonlar.Count > 0)
            {
                int index = random.Next(Butonlar.Count);
                Butonlar[index].Enabled = false; // Seçilen butonu devre dışı bırak
                oyuncuX = Oyuncular.O; // Bilgisayarın sembolü
                Butonlar[index].Text = oyuncuX.ToString(); // Butona 'O' yaz
                Butonlar[index].BackColor = Color.DarkSalmon; // Buton rengini değiştir
                Butonlar.RemoveAt(index); // Kullanılan butonu listeden çıkar
                OyunKontrol(); // Oyunun durumunu kontrol et
                ButonlarıEtkinleştir(true); // Butonları tekrar etkinleştir
                pcZaman.Stop(); // Zamanlayıcıyı durdur
            }
        }

        private void yenileButon(object sender, EventArgs e)
        {
            Yenile(); // Yenile butonuna tıklayınca oyunu yenile
        }

        private void OyuncuTikla(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Enabled) // Buton aktifse
            {
                oyuncuX = Oyuncular.X; // Kullanıcının sembolü
                button.Text = oyuncuX.ToString(); // Butona 'X' yaz
                button.Enabled = false; // Butonu devre dışı bırak
                button.BackColor = Color.Cyan; // Buton rengini değiştir
                Butonlar.Remove(button); // Kullanılan butonu listeden çıkar
                OyunKontrol(); // Oyunun durumunu kontrol et
                ButonlarıEtkinleştir(false); // Kullanıcı hamlesinden sonra butonları geçici olarak devre dışı bırak
                pcZaman.Start(); // Zamanlayıcıyı başlat
            }
        }

        private void ButonlarıEtkinleştir(bool durum)
        {
            // Tüm butonların etkinlik durumunu değiştirir
            foreach (var buton in Butonlar)
            {
                buton.Enabled = durum;
            }
        }

        private void Yenile()
        {
            Butonlar = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            // Her butonun içeriğini sıfırlar ve butonları tekrar aktif hale getirir
            foreach (Button x in Butonlar)
            {
                x.Enabled = true; // Butonları aktif hale getir
                x.Text = "?"; // Butonun içeriğini temizler
                x.BackColor = DefaultBackColor; // Buton rengini varsayılan renge döndür
            }
        }

        private void OyunKontrol()
        {
            // Oyuncu X'in kazanma durumu
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                pcZaman.Stop();
                MessageBox.Show("Player Won!!!");
                oyuncu++;
                PlayerText.Text = "Player: " + oyuncu;
                Yenile();
            }
            // Bilgisayar O'nun kazanma durumu
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                     button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                     button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                     button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                     button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                     button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                     button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                     button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                pcZaman.Stop();
                MessageBox.Show("Computer Won!!!");
                bilgisayar++;
                ComputerText.Text = "Computer: " + bilgisayar;
                Yenile();
            }
            // Beraberlik durumu
            else if (Butonlar.Count == 0)
            {
                MessageBox.Show("No Winner, It's a Draw!");
                Yenile();
            }
        }
    }
}


