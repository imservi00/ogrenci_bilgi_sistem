namespace OgrenciDersSecim
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            lblRol = new Label();
            cmbRol = new ComboBox();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.FromArgb(255, 128, 0);
            lblKullaniciAdi.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKullaniciAdi.Location = new Point(377, 261);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(106, 20);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            lblKullaniciAdi.Click += lblKullaniciAdi_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(569, 261);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(286, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.FromArgb(255, 128, 0);
            lblSifre.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = SystemColors.ButtonHighlight;
            lblSifre.Location = new Point(377, 364);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(46, 20);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(569, 364);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(286, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Lime;
            btnGirisYap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = SystemColors.ButtonHighlight;
            btnGirisYap.Location = new Point(446, 627);
            btnGirisYap.Margin = new Padding(3, 4, 3, 4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(321, 37);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.FromArgb(255, 128, 0);
            lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblRol.ForeColor = SystemColors.ButtonFace;
            lblRol.Location = new Point(377, 468);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(37, 20);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Ogrenci", "Memur", "Danisman" });
            cmbRol.Location = new Point(569, 468);
            cmbRol.Margin = new Padding(3, 4, 3, 4);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(286, 28);
            cmbRol.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 804);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
    }
}
