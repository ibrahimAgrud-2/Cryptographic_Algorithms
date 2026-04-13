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
    public partial class clsVigenereDcrypt : Form
    {
        public clsVigenereDcrypt()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToEncrypt.Text))
            {
                MessageBox.Show("Lütfen şifreli metni girin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Lütfen anahtar girin.");
                return;
            }

            txtResult.Text = Process(txtTextToEncrypt.Text, txtKey.Text, false);
        }


        private const int MOD = 26;

        // ===================== ENCRYPT =====================
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToEncrypt.Text))
            {
                MessageBox.Show("Lütfen şifrelenecek metni girin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Lütfen anahtar girin.");
                return;
            }

            txtResult.Text = Process(txtTextToEncrypt.Text, txtKey.Text, true);
        }

        // ===================== DECRYPT =====================
    

        // ===================== CORE =====================
        private string Process(string metin, string anahtar, bool encrypt)
        {
            metin = metin.ToUpper();
            anahtar = anahtar.ToUpper();

            string temizMetin = "";
            string temizAnahtar = "";

            foreach (char c in metin)
                if (char.IsLetter(c))
                    temizMetin += c;

            foreach (char c in anahtar)
                if (char.IsLetter(c))
                    temizAnahtar += c;

            if (temizAnahtar.Length == 0)
            {
                MessageBox.Show("Anahtar geçersiz!");
                return "";
            }

            string sonuc = "";
            int anahtarUzunluk = temizAnahtar.Length;

            for (int i = 0; i < temizMetin.Length; i++)
            {
                int m = temizMetin[i] - 'A';
                int k = temizAnahtar[i % anahtarUzunluk] - 'A';

                int r;

                if (encrypt)
                    r = (m + k) % MOD;          // Şifreleme
                else
                    r = (m - k + MOD) % MOD;     // Deşifreleme

                sonuc += (char)(r + 'A');
            }

            return sonuc;
        }
    }
}
