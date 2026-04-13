using System;
using System.Linq;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmDortKareDecrypt : Form
    {
     
        private const string STANDART_ALFABE = "ABCDEFGHIKLMNOPQRSTUVWXYZ";

        public frmDortKareDecrypt()
        {
            InitializeComponent();
        }

        private void frmDortKareDecrypt_Load(object sender, EventArgs e)
        {
        }


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToEncrypt.Text))
            {
                MessageBox.Show("Lütfen deşifrelenecek metni girin.", "Uyarı",
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
        
            char[,] kare1 = KareOlustur(STANDART_ALFABE);              // sol üst - standart
            char[,] kare2 = KareOlustur(AnahtarDonustur(anahtar1));    // sağ üst - anahtar1
            char[,] kare3 = KareOlustur(AnahtarDonustur(anahtar2));    // sol alt - anahtar2
            char[,] kare4 = KareOlustur(STANDART_ALFABE);              // sağ alt - standart

   
            metin = metin.ToUpper();
            string temizMetin = "";
            foreach (char c in metin)
                if (char.IsLetter(c))
                    temizMetin += c;

            if (temizMetin.Length % 2 != 0)
            {
                MessageBox.Show("Şifreli metin uzunluğu çift sayı olmalıdır!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

          
            return Desifrele(temizMetin, kare1, kare2, kare3, kare4);
        }


        private string Desifrele(string metin, char[,] kare1, char[,] kare2, char[,] kare3, char[,] kare4)
        {
            string duzMetin = "";

            for (int i = 0; i < metin.Length; i += 2)
            {
                char c1 = metin[i];
                char c2 = metin[i + 1];

            
                int satir1, sutun1;
                KaredeKonumBul(kare2, c1, out satir1, out sutun1);

            
                int satir2, sutun2;
                KaredeKonumBul(kare3, c2, out satir2, out sutun2);

      
                char p1 = kare1[satir1, sutun2];
                char p2 = kare4[satir2, sutun1];

                duzMetin += p1;
                duzMetin += p2;
            }

            return duzMetin;
        }

        private string AnahtarDonustur(string anahtar)
        {
            anahtar = anahtar.ToUpper().Replace("J", "I");

            string sonuc = "";

            foreach (char c in anahtar)
                if (char.IsLetter(c) && !sonuc.Contains(c))
                    sonuc += c;

            foreach (char c in STANDART_ALFABE)
                if (!sonuc.Contains(c))
                    sonuc += c;

            return sonuc;
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

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {
           
            btnDecrypt_Click(sender, e);
        }
    }
}