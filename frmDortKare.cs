using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmDortKare : Form
    {
        public frmDortKare()
        {
            
            
            InitializeComponent();
        }

      
        private const string STANDART_ALFABE = "ABCDEFGHIKLMNOPQRSTUVWXYZ";



 
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToEncrypt.Text))
            {
                MessageBox.Show("Lütfen şifrelenecek metni girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKey1.Text) ||
                string.IsNullOrWhiteSpace(txtKey2.Text))
            {
                MessageBox.Show("Lütfen her iki anahtarı da girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sonuc = Hazirlik(txtTextToEncrypt.Text, txtKey1.Text, txtKey2.Text);

            if (sonuc != "")
                txtResult.Text = sonuc;
        }


        private string Hazirlik(string metin, string anahtar1, string anahtar2)
        {
     
            char[,] kare1 = KareOlustur(STANDART_ALFABE); 
            char[,] kare2 = KareOlustur(AnahtarDonustur(anahtar1)); 
            char[,] kare3 = KareOlustur(AnahtarDonustur(anahtar2)); 
            char[,] kare4 = KareOlustur(STANDART_ALFABE);

    
            metin = metin.ToUpper().Replace("J", "I");
            string temizMetin = "";
            foreach (char c in metin)
                if (char.IsLetter(c))
                    temizMetin += c;

       
            if (temizMetin.Length % 2 != 0)
                temizMetin += 'X';

    
            return Sifrele(temizMetin, kare1, kare2, kare3, kare4);
        }


        private string Sifrele(string metin, char[,] kare1, char[,] kare2, char[,] kare3, char[,] kare4)
        {
            string sifreliMetin = "";

            for (int i = 0; i < metin.Length; i += 2)
            {
                char p1 = metin[i];
                char p2 = metin[i + 1];

                // P1'i Kare1'de bul
                int satir1, sutun1;
                KaredeKonumBul(kare1, p1, out satir1, out sutun1);

                // P2'yi Kare4'te bul
                int satir2, sutun2;
                KaredeKonumBul(kare4, p2, out satir2, out sutun2);

           
                char c1 = kare2[satir1, sutun2];
                char c2 = kare3[satir2, sutun1];

                sifreliMetin += c1;
                sifreliMetin += c2;
            }

            return sifreliMetin;
        }


        private string AnahtarDonustur(string anahtar)
        {
            anahtar = anahtar.ToUpper().Replace("J", "I");

            string sonuc = "";

            // Önce anahtar harflerini ekle (tekrar edenleri atla)
            foreach (char c in anahtar)
                if (char.IsLetter(c) && !sonuc.Contains(c))
                    sonuc += c;

            // Sonra kalan standart alfabe harflerini ekle
            foreach (char c in STANDART_ALFABE)
                if (!sonuc.Contains(c))
                    sonuc += c;

            return sonuc; // 25 harflik string
        }


        private char[,] KareOlustur(string alfabe25)
        {
            char[,] kare = new char[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    kare[i, j] = alfabe25[i * 5 + j];
            return kare;
        }

      
        private void KaredeKonumBul(char[,] kare, char harf, out int satir, out int sutun)
        {
            satir = 0;
            sutun = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (kare[i, j] == harf)
                    {
                        satir = i;
                        sutun = j;
                        return;
                    }
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            btnEncrypt_Click(sender, e);
        }
    }
}
