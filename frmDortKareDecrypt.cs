using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmDortKareDecrypt : Form
    {
        private const string STANDART_ALFABE = "ABCDEFGHIJKLMNOPRSTUVYZÇÖŞ";

        public frmDortKareDecrypt()
        {
            InitializeComponent();
        }

        private void frmDortKareDecrypt_Load(object sender, EventArgs e) { }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToEncrypt.Text))
            {
                MessageBox.Show("Lütfen deşifrelenecek metni girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKey1.Text) || string.IsNullOrWhiteSpace(txtKey2.Text))
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

            metin = metin.ToUpper(new System.Globalization.CultureInfo("tr-TR"));

            List<int> boslukPozisyonlari = new List<int>();
            for (int i = 0; i < metin.Length; i++)
                if (metin[i] == ' ')
                    boslukPozisyonlari.Add(i);

            string harfler = "";
            foreach (char c in metin)
                if (char.IsLetter(c))
                    harfler += c;

            if (harfler.Length % 2 != 0)
            {
                MessageBox.Show("Şifreli metin uzunluğu çift sayı olmalıdır!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            string duzMetin = Desifrele(harfler, kare1, kare2, kare3, kare4);

            // Şifreleme formundan haritayı al ve Türkçe karakterleri geri yükle
            duzMetin = TurkceleriGeriYukle(duzMetin, frmDortKare.TurkceKarakterHaritasi);

            System.Text.StringBuilder sb = new System.Text.StringBuilder(duzMetin);
            foreach (int pos in boslukPozisyonlari)
                if (pos <= sb.Length)
                    sb.Insert(pos, ' ');

            return sb.ToString();
        }

        private string TurkceleriGeriYukle(string metin, Dictionary<int, char> harita)
        {
            char[] karakterler = metin.ToCharArray();
            foreach (var kvp in harita)
                if (kvp.Key < karakterler.Length)
                    karakterler[kvp.Key] = kvp.Value;
            return new string(karakterler);
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

                duzMetin += kare1[satir1, sutun2];
                duzMetin += kare4[satir2, sutun1];
            }
            return duzMetin;
        }

        private string AnahtarDonustur(string anahtar)
        {
            anahtar = anahtar.ToUpper(new System.Globalization.CultureInfo("tr-TR"));
            anahtar = NormalizeTurkce(anahtar);

            string sonuc = "";
            foreach (char c in anahtar)
                if (char.IsLetter(c) && !sonuc.Contains(c) && STANDART_ALFABE.Contains(c))
                    sonuc += c;

            foreach (char c in STANDART_ALFABE)
                if (!sonuc.Contains(c))
                    sonuc += c;

            return sonuc;
        }

        private string NormalizeTurkce(string metin)
        {
            return metin
                .Replace('Ğ', 'G').Replace('Ü', 'U').Replace('İ', 'I')
                .Replace('Q', 'K').Replace('W', 'V').Replace('X', 'Z');
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
            satir = -1; sutun = -1;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (kare[i, j] == harf)
                    {
                        satir = i; sutun = j; return;
                    }
            if (satir == -1)
                throw new Exception($"'{harf}' harfi kare içinde bulunamadı!");
        }

        private void btnDecrypt_Click_1(object sender, EventArgs e) => btnDecrypt_Click(sender, e);

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            Form frm = new frmSendEmail();
            frm.ShowDialog();
        }
    }
}