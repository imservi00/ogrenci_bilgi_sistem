namespace OgrenciDersSecim
{
    partial class OgrenciAnaForm
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
            dataGridViewOgrenciDersleri = new DataGridView();
            btnDersEkle = new Button();
            btnDersSil = new Button();
            lblKrediToplam = new Label();
            btnDanismanaGonder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).BeginInit();
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
            dataGridViewDersler.Size = new Size(1251, 312);
            dataGridViewDersler.TabIndex = 0;
            // 
            // dataGridViewOgrenciDersleri
            // 
            dataGridViewOgrenciDersleri.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewOgrenciDersleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciDersleri.Location = new Point(11, 349);
            dataGridViewOgrenciDersleri.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOgrenciDersleri.Name = "dataGridViewOgrenciDersleri";
            dataGridViewOgrenciDersleri.RowHeadersWidth = 51;
            dataGridViewOgrenciDersleri.RowTemplate.Height = 24;
            dataGridViewOgrenciDersleri.Size = new Size(1251, 188);
            dataGridViewOgrenciDersleri.TabIndex = 1;
            // 
            // btnDersEkle
            // 
            btnDersEkle.BackColor = Color.Lime;
            btnDersEkle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDersEkle.ForeColor = Color.White;
            btnDersEkle.Location = new Point(371, 555);
            btnDersEkle.Margin = new Padding(3, 4, 3, 4);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(101, 37);
            btnDersEkle.TabIndex = 2;
            btnDersEkle.Text = "Ders Ekle";
            btnDersEkle.UseVisualStyleBackColor = false;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // btnDersSil
            // 
            btnDersSil.BackColor = Color.Red;
            btnDersSil.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDersSil.ForeColor = SystemColors.ButtonHighlight;
            btnDersSil.Location = new Point(371, 641);
            btnDersSil.Margin = new Padding(3, 4, 3, 4);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(101, 37);
            btnDersSil.TabIndex = 3;
            btnDersSil.Text = "Ders Sil";
            btnDersSil.UseVisualStyleBackColor = false;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // lblKrediToplam
            // 
            lblKrediToplam.AutoSize = true;
            lblKrediToplam.Location = new Point(762, 563);
            lblKrediToplam.Name = "lblKrediToplam";
            lblKrediToplam.Size = new Size(113, 20);
            lblKrediToplam.TabIndex = 4;
            lblKrediToplam.Text = "Toplam Kredi: 0";
            // 
            // btnDanismanaGonder
            // 
            btnDanismanaGonder.BackColor = Color.FromArgb(255, 128, 0);
            btnDanismanaGonder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDanismanaGonder.ForeColor = SystemColors.ButtonHighlight;
            btnDanismanaGonder.Location = new Point(939, 555);
            btnDanismanaGonder.Margin = new Padding(3, 4, 3, 4);
            btnDanismanaGonder.Name = "btnDanismanaGonder";
            btnDanismanaGonder.Size = new Size(292, 53);
            btnDanismanaGonder.TabIndex = 5;
            btnDanismanaGonder.Text = "Danışmana Gönder";
            btnDanismanaGonder.UseVisualStyleBackColor = false;
            btnDanismanaGonder.Click += btnDanismanaGonder_Click;
            // 
            // OgrenciAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 803);
            Controls.Add(btnDanismanaGonder);
            Controls.Add(lblKrediToplam);
            Controls.Add(btnDersSil);
            Controls.Add(btnDersEkle);
            Controls.Add(dataGridViewOgrenciDersleri);
            Controls.Add(dataGridViewDersler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgrenciAnaForm";
            Text = "Öğrenci Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciDersleri;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Label lblKrediToplam;
        private System.Windows.Forms.Button btnDanismanaGonder;
    }
}
