using System;
using Decrypt;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmDecrypt : Form
    {
        public frmDecrypt()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string metin = txtToDecrypt.Text;
           // string secim = comboBoxEncryption.SelectedItem?.ToString();
            string sonuc = "";

            try
            {
                switch (guna2ComboBox1.SelectedIndex)
                {
                    case 0:
                        int key1_kaydir = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsDecrypt.kaydirmaliDesifreleme(metin, key1_kaydir);
                        break;

                    case 1:
                        int key1_dogrusal = Convert.ToInt32(txtKey1.Text);
                        int key2_dogrusal = Convert.ToInt32(txtKey2.Text);
                        sonuc = clsDecrypt.dogrusalDesifreleme(metin, key1_dogrusal, key2_dogrusal);
                        break;

                    case 2:
                        sonuc = clsDecrypt.yerDegistirmeDesifreleme(metin);
                        break;

                    case 3:
                        int key1_sayi = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsDecrypt.sayiAnahtarliDesifreleme(metin, key1_sayi);
                        break;

                    case 4:
                        sonuc = clsDecrypt.PermutasyonDesifrele(metin);
                        break;

                    case 5:
                        int key1_rota = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsDecrypt.rotaDesifrele(metin, key1_rota);
                        break;

                    case 6:
                        int key1_zigzag = Convert.ToInt32(txtKey1.Text);
                        sonuc = clsDecrypt.zigzagDesifrele(metin, key1_zigzag);
                        break;

                    default:
                        MessageBox.Show("Lütfen bir algoritma seçin.");
                        return;
                }

                txtDecrypted.Text = sonuc;
            }
            catch (FormatException)
            {
                MessageBox.Show("Anahtar alanına geçerli bir sayı giriniz.");
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
