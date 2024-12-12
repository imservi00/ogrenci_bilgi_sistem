namespace OgrenciDersSecim
{
    partial class DersDuzenleForm
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
            dataGridViewDersler = new DataGridView();
            txtDersID = new TextBox();
            txtDersAdi = new TextBox();
            txtKredi = new TextBox();
            txtKontenjan = new TextBox();
            chkAktif = new CheckBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            lblDersID = new Label();
            lblDersAdi = new Label();
            lblKredi = new Label();
            lblKontenjan = new Label();
            lblAktif = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDersler
            // 
            dataGridViewDersler.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDersler.Location = new Point(11, 15);
            dataGridViewDersler.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDersler.Name = "dataGridViewDersler";
            dataGridViewDersler.RowHeadersWidth = 51;
            dataGridViewDersler.RowTemplate.Height = 24;
            dataGridViewDersler.Size = new Size(1250, 251);
            dataGridViewDersler.TabIndex = 0;
            dataGridViewDersler.CellClick += dataGridViewDersler_CellClick;
            // 
            // txtDersID
            // 
            txtDersID.Location = new Point(335, 308);
            txtDersID.Margin = new Padding(3, 4, 3, 4);
            txtDersID.Name = "txtDersID";
            txtDersID.ReadOnly = true;
            txtDersID.Size = new Size(180, 27);
            txtDersID.TabIndex = 1;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(337, 377);
            txtDersAdi.Margin = new Padding(3, 4, 3, 4);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(180, 27);
            txtDersAdi.TabIndex = 2;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(337, 443);
            txtKredi.Margin = new Padding(3, 4, 3, 4);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(180, 27);
            txtKredi.TabIndex = 3;
            // 
            // txtKontenjan
            // 
            txtKontenjan.Location = new Point(337, 500);
            txtKontenjan.Margin = new Padding(3, 4, 3, 4);
            txtKontenjan.Name = "txtKontenjan";
            txtKontenjan.Size = new Size(180, 27);
            txtKontenjan.TabIndex = 4;
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.BackColor = Color.Lime;
            chkAktif.Location = new Point(337, 563);
            chkAktif.Margin = new Padding(3, 4, 3, 4);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(62, 24);
            chkAktif.TabIndex = 5;
            chkAktif.Text = "Aktif";
            chkAktif.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Blue;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(821, 308);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(181, 37);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(821, 399);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(181, 37);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(821, 483);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(181, 37);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblDersID
            // 
            lblDersID.AutoSize = true;
            lblDersID.Location = new Point(203, 308);
            lblDersID.Name = "lblDersID";
            lblDersID.Size = new Size(61, 20);
            lblDersID.TabIndex = 9;
            lblDersID.Text = "Ders ID:";
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Location = new Point(203, 377);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(69, 20);
            lblDersAdi.TabIndex = 10;
            lblDersAdi.Text = "Ders Adı:";
            // 
            // lblKredi
            // 
            lblKredi.AutoSize = true;
            lblKredi.Location = new Point(203, 443);
            lblKredi.Name = "lblKredi";
            lblKredi.Size = new Size(47, 20);
            lblKredi.TabIndex = 11;
            lblKredi.Text = "Kredi:";
            // 
            // lblKontenjan
            // 
            lblKontenjan.AutoSize = true;
            lblKontenjan.Location = new Point(203, 500);
            lblKontenjan.Name = "lblKontenjan";
            lblKontenjan.Size = new Size(79, 20);
            lblKontenjan.TabIndex = 12;
            lblKontenjan.Text = "Kontenjan:";
            // 
            // lblAktif
            // 
            lblAktif.AutoSize = true;
            lblAktif.Location = new Point(237, 568);
            lblAktif.Name = "lblAktif";
            lblAktif.Size = new Size(43, 20);
            lblAktif.TabIndex = 13;
            lblAktif.Text = "Aktif:";
            // 
            // DersDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 801);
            Controls.Add(lblAktif);
            Controls.Add(lblKontenjan);
            Controls.Add(lblKredi);
            Controls.Add(lblDersAdi);
            Controls.Add(lblDersID);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(chkAktif);
            Controls.Add(txtKontenjan);
            Controls.Add(txtKredi);
            Controls.Add(txtDersAdi);
            Controls.Add(txtDersID);
            Controls.Add(dataGridViewDersler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DersDuzenleForm";
            Text = "Ders Düzenle";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtKontenjan;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblDersID;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.Label lblKontenjan;
        private System.Windows.Forms.Label lblAktif;
    }
}
