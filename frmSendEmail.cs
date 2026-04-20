using MimeKit;
using System;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmSendEmail : Form
    {
        public frmSendEmail()
        {
            InitializeComponent();
        }

        public async Task<bool> EpostaGonderAsync(string aliciEmail, string konu, string mesajIcerigi)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(new MailboxAddress("Kripto Uygulaması", "ibrahimakkurt566@gmail.com"));
                email.To.Add(new MailboxAddress("Alıcı", aliciEmail));
                email.Subject = konu;

                email.Body = new TextPart("plain") { Text = mesajIcerigi };

                using (var smtp = new SmtpClient())
                {
                    // Sunucu bağlantı ayarları
                    await smtp.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                    // Kimlik doğrulama (Uygulama Şifresi kullanılmalıdır)
                    await smtp.AuthenticateAsync("ibrahimakkurt566@gmail.com", "tqqm riwu dlpr keaj");

                    await smtp.SendAsync(email);
                    await smtp.DisconnectAsync(true);
                }
                return true; // Gönderim başarılı
            }
            catch
            {
                return false; // Gönderim sırasında hata oluştu
            }
        }


        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string sifreliMetin = txtBody.Text;
            string hedefAdres = txtTo.Text;

            // İşlem başladığında kullanıcıyı bilgilendirelim
            lblDurum.Text = "E-posta hazırlanıyor...";
            guna2Button1.Enabled = false; // Çift tıklamayı önlemek için butonu pasif yapıyoruz

            try
            {
                // 'await' artık burada düzgün çalışacaktır.
                bool sonuc = await EpostaGonderAsync(hedefAdres, "Şifreli Mesaj", sifreliMetin);

                if (sonuc)
                {
                    MessageBox.Show("E-posta başarıyla gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDurum.Text = "Gönderim tamamlandı.";
                }
                else
                {
                    MessageBox.Show("E-posta gönderilemedi. Lütfen ayarları kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblDurum.Text = "Hata oluştu.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik bir hata: {ex.Message}");
            }
            finally
            {
                guna2Button1.Enabled = true; // İşlem bittiğinde butonu tekrar aktif ediyoruz
            }
        }

        private void frmSendEmail_Load(object sender, EventArgs e)
        {
            txtFrom.Text = "ibrahimakkurt566@gmail.com"; 
            txtTo.Text =  "hasaneleyvi090@gmail.com";

        }
    }
}
