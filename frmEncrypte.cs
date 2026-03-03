using System;
using Encrypt;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmEncrypte : Form
    {
        public frmEncrypte()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string metin = txtToEncrypte.Text;
            string secim = guna2ComboBox1.SelectedItem?.ToString();
            string sonuc = "";


            try
            {
                switch (guna2ComboBox1.SelectedIndex)
                {
                    case 0:
                        int key1_kaydir = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsEncrypt.kaydirmaliSifreleme(metin, key1_kaydir);
                        break;

                    case 1:
                        int key1_dogrusal = Convert.ToInt32(txtKey1.Text);
                        int key2_dogrusal = Convert.ToInt32(txtKey2.Text);
                        sonuc = clsEncrypt.dogrusalSifreleme(metin, key1_dogrusal, key2_dogrusal);
                        break;

                    case 2:
                        sonuc = clsEncrypt.yerDegistirme(metin);
                        break;

                    case 3:
                        int key1_sayi = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsEncrypt.sayiAnahtarliSifreleme(metin, key1_sayi);
                        break;

                    case 4:
                        sonuc = clsEncrypt.PermutasyonSifrele(metin);
                        break;

                    case 5:
                        int key1_rota = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsEncrypt.rotaSifrele(metin, key1_rota);
                        break;

                    case 6:
                        int key1_zigzag = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsEncrypt.zigzagSİfrele(metin, key1_zigzag);
                        break;

                    default:
                        MessageBox.Show("Lütfen bir şifreleme algoritması seçin.");
                        return;
                }

                txtEncrypted.Text = sonuc;
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir anahtar girin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmSendEmail();
            frm.ShowDialog();
        }
    }
}
