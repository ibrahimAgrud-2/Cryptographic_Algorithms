namespace KriptolojiOdevi
{
    partial class frmDortKareDecrypt
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
            this.lblPlain = new System.Windows.Forms.Label();
            this.txtTextToEncrypt = new System.Windows.Forms.TextBox();
            this.lblKey1 = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.lblKey2 = new System.Windows.Forms.Label();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlain
            // 
            this.lblPlain.AutoSize = true;
            this.lblPlain.Location = new System.Drawing.Point(300, 29);
            this.lblPlain.Name = "lblPlain";
            this.lblPlain.Size = new System.Drawing.Size(110, 26);
            this.lblPlain.TabIndex = 9;
            this.lblPlain.Text = "Düz Metin";
            // 
            // txtTextToEncrypt
            // 
            this.txtTextToEncrypt.Location = new System.Drawing.Point(300, 59);
            this.txtTextToEncrypt.Multiline = true;
            this.txtTextToEncrypt.Name = "txtTextToEncrypt";
            this.txtTextToEncrypt.Size = new System.Drawing.Size(400, 80);
            this.txtTextToEncrypt.TabIndex = 10;
            // 
            // lblKey1
            // 
            this.lblKey1.AutoSize = true;
            this.lblKey1.Location = new System.Drawing.Point(300, 159);
            this.lblKey1.Name = "lblKey1";
            this.lblKey1.Size = new System.Drawing.Size(106, 26);
            this.lblKey1.TabIndex = 11;
            this.lblKey1.Text = "Anahtar 1";
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(300, 189);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(150, 32);
            this.txtKey1.TabIndex = 12;
            // 
            // lblKey2
            // 
            this.lblKey2.AutoSize = true;
            this.lblKey2.Location = new System.Drawing.Point(520, 159);
            this.lblKey2.Name = "lblKey2";
            this.lblKey2.Size = new System.Drawing.Size(106, 26);
            this.lblKey2.TabIndex = 13;
            this.lblKey2.Text = "Anahtar 2";
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(520, 189);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(150, 32);
            this.txtKey2.TabIndex = 14;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(300, 249);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(370, 40);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Deşifrele";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(300, 309);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(74, 26);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Sonuç";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(300, 339);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(400, 100);
            this.txtResult.TabIndex = 17;
            // 
            // frmDortKareDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1015, 607);
            this.Controls.Add(this.lblPlain);
            this.Controls.Add(this.txtTextToEncrypt);
            this.Controls.Add(this.lblKey1);
            this.Controls.Add(this.txtKey1);
            this.Controls.Add(this.lblKey2);
            this.Controls.Add(this.txtKey2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDortKareDecrypt";
            this.Text = "frmDortKareDecrypt";
            this.Load += new System.EventHandler(this.frmDortKareDecrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlain;
        private System.Windows.Forms.TextBox txtTextToEncrypt;
        private System.Windows.Forms.Label lblKey1;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.Label lblKey2;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}