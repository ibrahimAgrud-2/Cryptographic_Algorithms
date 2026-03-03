namespace KriptolojiOdevi
{
    partial class frmDecrypt
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToDecrypt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtDecrypted = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1281, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decrypt Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Key";
            // 
            // txtKey1
            // 
            this.txtKey1.BorderRadius = 20;
            this.txtKey1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey1.DefaultText = "";
            this.txtKey1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKey1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey1.Location = new System.Drawing.Point(130, 522);
            this.txtKey1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.PlaceholderText = "";
            this.txtKey1.SelectedText = "";
            this.txtKey1.Size = new System.Drawing.Size(395, 60);
            this.txtKey1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Text To Decrypt";
            // 
            // txtToDecrypt
            // 
            this.txtToDecrypt.BorderRadius = 20;
            this.txtToDecrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToDecrypt.DefaultText = "";
            this.txtToDecrypt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtToDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtToDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToDecrypt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToDecrypt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtToDecrypt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToDecrypt.Location = new System.Drawing.Point(104, 184);
            this.txtToDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToDecrypt.Name = "txtToDecrypt";
            this.txtToDecrypt.PlaceholderText = "";
            this.txtToDecrypt.SelectedText = "";
            this.txtToDecrypt.Size = new System.Drawing.Size(411, 129);
            this.txtToDecrypt.TabIndex = 13;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Tan;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(307, 659);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(227, 76);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Decrypt";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.BorderRadius = 20;
            this.txtDecrypted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDecrypted.DefaultText = "";
            this.txtDecrypted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDecrypted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDecrypted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDecrypted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDecrypted.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDecrypted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDecrypted.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDecrypted.Location = new System.Drawing.Point(713, 194);
            this.txtDecrypted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.PlaceholderText = "";
            this.txtDecrypted.SelectedText = "";
            this.txtDecrypted.Size = new System.Drawing.Size(411, 129);
            this.txtDecrypted.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Decrypted Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Key";
            // 
            // txtKey2
            // 
            this.txtKey2.BorderRadius = 20;
            this.txtKey2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey2.DefaultText = "";
            this.txtKey2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKey2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey2.Location = new System.Drawing.Point(713, 522);
            this.txtKey2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.PlaceholderText = "";
            this.txtKey2.SelectedText = "";
            this.txtKey2.Size = new System.Drawing.Size(395, 60);
            this.txtKey2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(421, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Doğrusal seçerseniz 2 anahtar girmelisiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Encryption Options";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "1. Kaydırmalı şifreleme",
            "2. Doğrusal şifreleme",
            "3. Yer değiştirme şifreleme",
            "4. Sayı anahtarlı şifreleme",
            "5. Permütasyon şifreleme",
            "6. Rota şifreleme",
            "7. Zigzag şifreleme"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(139, 407);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(395, 36);
            this.guna2ComboBox1.TabIndex = 21;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 13;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Tan;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(654, 659);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(227, 76);
            this.guna2Button2.TabIndex = 24;
            this.guna2Button2.Text = "Send EmaiL";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // frmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1281, 820);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKey2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToDecrypt);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDecrypt";
            this.Text = "frmDecrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtKey1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtToDecrypt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtDecrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtKey2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}