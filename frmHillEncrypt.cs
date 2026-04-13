using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmHillEncrypt : Form
    {
        public frmHillEncrypt()
        {
            InitializeComponent();
        }

        private static readonly char[] ALFABE = {
            'A','B','C','Ç','D','E','F','G','Ğ','H',  // 0-9
            'I','İ','J','K','L','M','N','O','Ö','P',  // 10-19
            'R','S','Ş','T','U','Ü','V','Y','Z'        // 20-28
        };

        private const int MOD = 29;

       

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEncrypt.Text))
            {
                MessageBox.Show("Lütfen şifrelenecek metni girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRow1.Text) ||
                string.IsNullOrWhiteSpace(txtRow2.Text) ||
                string.IsNullOrWhiteSpace(txtRow3.Text))
            {
                MessageBox.Show("Lütfen tüm anahtar satırlarını doldurun.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            string sonuc = Hazirlik(txtEncrypt.Text, txtRow1.Text, txtRow2.Text, txtRow3.Text);

            if (sonuc != "")
                txtEncryptedText.Text = sonuc;
        }

        private string Hazirlik(string metin, string satir1, string satir2, string satir3)
        {

            int[,] anahtar = new int[3, 3];
            string[] satirlar = { satir1, satir2, satir3 };

            for (int i = 0; i < 3; i++)
            {
                string[] elemanlar = satirlar[i].Split(',');

                if (elemanlar.Length != 3)
                {
                    MessageBox.Show($"Satır {i + 1} hatalı!\nDoğru format: '6,22,5'", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                for (int j = 0; j < 3; j++)
                {
                    if (!int.TryParse(elemanlar[j].Trim(), out anahtar[i, j]))
                    {
                        MessageBox.Show($"Satır {i + 1}, {j + 1}. eleman sayı değil!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                }
            }

        
            metin = metin.ToUpper(new System.Globalization.CultureInfo("tr-TR")).Replace(" ", "");

       
            List<int> sayilar = new List<int>();

            foreach (char harf in metin)
            {
                int index = HarftenSayiya(harf);
                if (index == -1)
                {
                    MessageBox.Show($"'{harf}' harfi Türkçe alfabede yok!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                sayilar.Add(index);
            }

       
            while (sayilar.Count % 3 != 0)
                sayilar.Add(0); // 'A' = 0

     
            return Sifrele(sayilar, anahtar);
        }


        private string Sifrele(List<int> sayilar, int[,] anahtar)
        {
            string sifreliMetin = "";

            for (int blok = 0; blok < sayilar.Count; blok += 3)
            {
                // 3'lü bloğu al → örn: [6, 0, 9]
                int[] blokVektor = new int[3];
                for (int i = 0; i < 3; i++)
                    blokVektor[i] = sayilar[blok + i];

      
                int[] sonucVektor = new int[3];

                for (int j = 0; j < 3; j++)
                {
                    int toplam = 0;
                    for (int k = 0; k < 3; k++)
                        toplam += blokVektor[k] * anahtar[k, j];

                    sonucVektor[j] = toplam % MOD;
                }

                // Sayıları harfe çevir
                for (int i = 0; i < 3; i++)
                    sifreliMetin += SayidanHarfe(sonucVektor[i]);
            }

            return sifreliMetin;
        }




        private int HarftenSayiya(char harf)
        {
            for (int i = 0; i < ALFABE.Length; i++)
                if (ALFABE[i] == harf) return i;
            return -1;
        }

        private char SayidanHarfe(int sayi)
        {
            return ALFABE[sayi % MOD];
        }

        private void frmHillEncrypt_Load(object sender, EventArgs e)
        {

        }
    }
}
