namespace KriptolojiOdevi
{
    partial class frmVigenere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDuzMetin = new System.Windows.Forms.Label();
            this.txtTextToEncrypt = new System.Windows.Forms.TextBox();
            this.lblAnahtar = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDuzMetin
            // 
            this.lblDuzMetin.AutoSize = true;
            this.lblDuzMetin.Location = new System.Drawing.Point(335, 40);
            this.lblDuzMetin.Name = "lblDuzMetin";
            this.lblDuzMetin.Size = new System.Drawing.Size(110, 26);
            this.lblDuzMetin.TabIndex = 0;
            this.lblDuzMetin.Text = "Düz Metin";
            // 
            // txtTextToEncrypt
            // 
            this.txtTextToEncrypt.BackColor = System.Drawing.Color.White;
            this.txtTextToEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTextToEncrypt.Location = new System.Drawing.Point(110, 75);
            this.txtTextToEncrypt.Multiline = true;
            this.txtTextToEncrypt.Name = "txtTextToEncrypt";
            this.txtTextToEncrypt.Size = new System.Drawing.Size(600, 120);
            this.txtTextToEncrypt.TabIndex = 1;
            // 
            // lblAnahtar
            // 
            this.lblAnahtar.AutoSize = true;
            this.lblAnahtar.Location = new System.Drawing.Point(110, 220);
            this.lblAnahtar.Name = "lblAnahtar";
            this.lblAnahtar.Size = new System.Drawing.Size(88, 26);
            this.lblAnahtar.TabIndex = 2;
            this.lblAnahtar.Text = "Anahtar";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Location = new System.Drawing.Point(110, 255);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(600, 32);
            this.txtKey.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Tan;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(110, 320);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(600, 50);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Şifrele";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(335, 400);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(74, 26);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Location = new System.Drawing.Point(110, 435);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(600, 120);
            this.txtResult.TabIndex = 6;
            // 
            // frmVigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(820, 620);
            this.Controls.Add(this.lblDuzMetin);
            this.Controls.Add(this.txtTextToEncrypt);
            this.Controls.Add(this.lblAnahtar);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVigenere";
            this.Text = "Vigenere Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Kontrol tanımlamaları
        private System.Windows.Forms.Label lblDuzMetin;
        private System.Windows.Forms.TextBox txtTextToEncrypt;
        private System.Windows.Forms.Label lblAnahtar;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtResult;
           

        

       
    }
}