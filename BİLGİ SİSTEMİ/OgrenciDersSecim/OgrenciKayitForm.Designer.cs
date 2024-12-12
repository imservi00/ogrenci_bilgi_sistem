namespace OgrenciDersSecim
{
    partial class OgrenciKayitForm
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtGano = new TextBox();
            btnKaydet = new Button();
            lblAd = new Label();
            lblSoyad = new Label();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            lblGano = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(150, 25);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(533, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(150, 75);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(533, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(150, 125);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(533, 27);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(150, 175);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(533, 27);
            txtSifre.TabIndex = 3;
            // 
            // txtGano
            // 
            txtGano.Location = new Point(150, 225);
            txtGano.Margin = new Padding(3, 4, 3, 4);
            txtGano.Name = "txtGano";
            txtGano.Size = new Size(533, 27);
            txtGano.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Chartreuse;
            btnKaydet.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnKaydet.Location = new Point(553, 422);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(168, 112);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(50, 25);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(31, 20);
            lblAd.TabIndex = 6;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(50, 75);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 20);
            lblSoyad.TabIndex = 7;
            lblSoyad.Text = "Soyad:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(50, 125);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 20);
            lblKullaniciAdi.TabIndex = 8;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(50, 175);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 20);
            lblSifre.TabIndex = 9;
            lblSifre.Text = "Şifre:";
            // 
            // lblGano
            // 
            lblGano.AutoSize = true;
            lblGano.Location = new Point(50, 225);
            lblGano.Name = "lblGano";
            lblGano.Size = new Size(54, 20);
            lblGano.TabIndex = 10;
            lblGano.Text = "GANO:";
            // 
            // OgrenciKayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 807);
            Controls.Add(lblGano);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(btnKaydet);
            Controls.Add(txtGano);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgrenciKayitForm";
            Text = "Öğrenci Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtGano;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblGano;
    }
}
