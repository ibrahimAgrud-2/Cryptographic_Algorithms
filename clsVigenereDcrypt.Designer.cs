namespace KriptolojiOdevi
{
    partial class clsVigenereDcrypt
    {
        /// <summary>
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // CONTROLS
        private System.Windows.Forms.TextBox txtTextToEncrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblCipherText;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTextToEncrypt = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblCipherText = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextToEncrypt
            // 
            this.txtTextToEncrypt.Location = new System.Drawing.Point(167, 35);
            this.txtTextToEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTextToEncrypt.Multiline = true;
            this.txtTextToEncrypt.Name = "txtTextToEncrypt";
            this.txtTextToEncrypt.Size = new System.Drawing.Size(435, 78);
            this.txtTextToEncrypt.TabIndex = 0;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(167, 125);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(201, 22);
            this.txtKey.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(167, 208);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(435, 78);
            this.txtResult.TabIndex = 2;
            // 
            // lblCipherText
            // 
            this.lblCipherText.AutoSize = true;
            this.lblCipherText.Location = new System.Drawing.Point(40, 38);
            this.lblCipherText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCipherText.Name = "lblCipherText";
            this.lblCipherText.Size = new System.Drawing.Size(75, 16);
            this.lblCipherText.TabIndex = 3;
            this.lblCipherText.Text = "Şifreli Metin";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(40, 128);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(53, 16);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Anahtar";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(40, 211);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Sonuç";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(167, 160);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(120, 29);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Deşifrele";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 160);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Temizle";
            // 
            // clsVigenereDcrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(946, 625);
            this.Controls.Add(this.txtTextToEncrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblCipherText);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnClear);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "clsVigenereDcrypt";
            this.Text = "Vigenere Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    

        }

}