namespace KriptolojiOdevi
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btnDecrypte = new Guna.UI2.WinForms.Guna2Button();
            this.btnSendEmail = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1199, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decrypt-Encrypt Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BorderRadius = 13;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.Tan;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(90, 275);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(266, 207);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnDecrypte
            // 
            this.btnDecrypte.BorderRadius = 13;
            this.btnDecrypte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypte.FillColor = System.Drawing.Color.Tan;
            this.btnDecrypte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDecrypte.ForeColor = System.Drawing.Color.White;
            this.btnDecrypte.Location = new System.Drawing.Point(463, 275);
            this.btnDecrypte.Name = "btnDecrypte";
            this.btnDecrypte.Size = new System.Drawing.Size(266, 207);
            this.btnDecrypte.TabIndex = 7;
            this.btnDecrypte.Text = "Decrypt";
            this.btnDecrypte.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BorderRadius = 13;
            this.btnSendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendEmail.FillColor = System.Drawing.Color.Tan;
            this.btnSendEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(842, 275);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(266, 207);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1199, 797);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnDecrypte);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEncrypt;
        private Guna.UI2.WinForms.Guna2Button btnDecrypte;
        private Guna.UI2.WinForms.Guna2Button btnSendEmail;
    }
}

