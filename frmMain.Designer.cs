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
            this.btnDecrypte = new Guna.UI2.WinForms.Guna2Button();
            this.btnSendEmail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1.SuspendLayout();
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
            this.btnDecrypte.Location = new System.Drawing.Point(15, 57);
            this.btnDecrypte.Name = "btnDecrypte";
            this.btnDecrypte.Size = new System.Drawing.Size(209, 81);
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
            this.btnSendEmail.Location = new System.Drawing.Point(614, 535);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(266, 207);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Tan;
            this.guna2GroupBox1.Controls.Add(this.btnDecrypte);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Tan;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(96, 300);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(448, 314);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1199, 797);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDecrypte;
        private Guna.UI2.WinForms.Guna2Button btnSendEmail;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}

