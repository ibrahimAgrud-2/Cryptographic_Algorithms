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
    public partial class frmVigenere : Form
    {
        public frmVigenere()
        {
            InitializeComponent();
        }
        private const int MOD = 26;

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToEncrypt.Text))
            {
                MessageBox.Show("Lütfen şifrelenecek metni girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Lütfen anahtar kelimeyi girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sonuc = Hazirlik(txtTextToEncrypt.Text, txtKey.Text);

            if (sonuc != "")
                txtResult.Text = sonuc;
        }


    
        private string Hazirlik(string metin, string anahtar)
        {
            // ── Adım 1: Metni temizle ─────────────────────────────
            metin = metin.ToUpper();
            string temizMetin = "";
            foreach (char c in metin)
                if (char.IsLetter(c))
                    temizMetin += c;

            // ── Adım 2: Anahtarı temizle ──────────────────────────
            anahtar = anahtar.ToUpper();
            string temizAnahtar = "";
            foreach (char c in anahtar)
                if (char.IsLetter(c))
                    temizAnahtar += c;

            if (temizAnahtar.Length == 0)
            {
                MessageBox.Show("Anahtar en az bir harf içermelidir!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            // ── Adım 3: Her şey hazır → Sifrele'ye gönder ────────
            return Sifrele(temizMetin, temizAnahtar);
        }


        private string Sifrele(string metin, string anahtar)
        {
            string sifreliMetin = "";
            int anahtarUzunluk = anahtar.Length;

            for (int i = 0; i < metin.Length; i++)
            {
                // Düz harfi sayıya çevir (A=0, B=1, ... Z=25)
                int duzSayi = metin[i] - 'A';

                // Anahtar harfini sayıya çevir
                // i % anahtarUzunluk → anahtar bitince başa döner
                // Örn: i=3, anahtar="KEY" → 3%3=0 → 'K'
                int anahtarSayi = anahtar[i % anahtarUzunluk] - 'A';

                // Şifreli sayı = (düz + anahtar) mod 26
                int sifreliSayi = (duzSayi + anahtarSayi) %MOD ;

                // Sayıyı harfe çevir
                sifreliMetin += (char)(sifreliSayi + 'A');
            }

            return sifreliMetin;
        }
    }
}
