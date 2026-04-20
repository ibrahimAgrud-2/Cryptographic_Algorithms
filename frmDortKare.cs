using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmDortKare : Form
    {
        private const string STANDART_ALFABE = "ABCDEFGHIJKLMNOPRSTUVYZÇÖŞ";

        public static Dictionary<int, char> TurkceKarakterHaritasi = new Dictionary<int, char>();
        public static int OrijinalHarfSayisi = 0;

        public frmDortKare()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToEncrypt.Text))
            {
                MessageBox.Show("Lütfen şifrelenecek metni girin.", "Uyarı",
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

            // Boşlukları ve harf olmayan karakterleri sil
            string harfler = "";
            foreach (char c in metin)
                if (char.IsLetter(c))
                    harfler += c;

            // Türkçe karakterleri normalize et, pozisyonları kaydet
            TurkceKarakterHaritasi.Clear();
            harfler = NormalizeVeKaydet(harfler);

            // Orijinal harf sayısını sakla
            OrijinalHarfSayisi = harfler.Length;

            if (harfler.Length % 2 != 0)
                harfler += 'Z';

            return Sifrele(harfler, kare1, kare2, kare3, kare4);
        }

        private string NormalizeVeKaydet(string metin)
        {
            var donusum = new Dictionary<char, char>
            {
                { 'Ğ', 'G' }, { 'Ü', 'U' }, { 'İ', 'I' },
                { 'Q', 'K' }, { 'W', 'V' }, { 'X', 'Z' }
            };

            string sonuc = "";
            for (int i = 0; i < metin.Length; i++)
            {
                char c = metin[i];
                if (donusum.ContainsKey(c))
                {
                    TurkceKarakterHaritasi[i] = c;
                    sonuc += donusum[c];
                }
                else
                    sonuc += c;
            }
            return sonuc;
        }

        private string Sifrele(string metin, char[,] kare1, char[,] kare2, char[,] kare3, char[,] kare4)
        {
            string sifreliMetin = "";
            for (int i = 0; i < metin.Length; i += 2)
            {
                char p1 = metin[i];
                char p2 = metin[i + 1];

                int satir1, sutun1;
                KaredeKonumBul(kare1, p1, out satir1, out sutun1);

                int satir2, sutun2;
                KaredeKonumBul(kare4, p2, out satir2, out sutun2);

                sifreliMetin += kare2[satir1, sutun2];
                sifreliMetin += kare3[satir2, sutun1];
            }
            return sifreliMetin;
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
                    { satir = i; sutun = j; return; }

            if (satir == -1)
                throw new Exception($"'{harf}' harfi kare içinde bulunamadı!");
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e) => btnEncrypt_Click(sender, e);
    }
}