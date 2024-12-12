namespace OgrenciDersSecim
{
    partial class MemurAnaForm
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
            btnOgrenciKayit = new Button();
            btnDersDuzenle = new Button();
            btnOgrenciRaporu = new Button();
            btnCikisYap = new Button();
            btnOgrenciSil = new Button();
            SuspendLayout();
            // 
            // btnOgrenciKayit
            // 
            btnOgrenciKayit.BackColor = Color.Lime;
            btnOgrenciKayit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgrenciKayit.ForeColor = Color.Transparent;
            btnOgrenciKayit.Location = new Point(52, 37);
            btnOgrenciKayit.Margin = new Padding(3, 4, 3, 4);
            btnOgrenciKayit.Name = "btnOgrenciKayit";
            btnOgrenciKayit.Size = new Size(232, 262);
            btnOgrenciKayit.TabIndex = 0;
            btnOgrenciKayit.Text = "Öğrenci Kayıt";
            btnOgrenciKayit.UseVisualStyleBackColor = false;
            btnOgrenciKayit.Click += btnOgrenciKayit_Click;
            // 
            // btnDersDuzenle
            // 
            btnDersDuzenle.BackColor = Color.Blue;
            btnDersDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDersDuzenle.ForeColor = Color.White;
            btnDersDuzenle.Location = new Point(719, 37);
            btnDersDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDersDuzenle.Name = "btnDersDuzenle";
            btnDersDuzenle.Size = new Size(201, 262);
            btnDersDuzenle.TabIndex = 1;
            btnDersDuzenle.Text = "Dersleri Düzenle";
            btnDersDuzenle.UseVisualStyleBackColor = false;
            btnDersDuzenle.Click += btnDersDuzenle_Click;
            // 
            // btnOgrenciRaporu
            // 
            btnOgrenciRaporu.BackColor = Color.FromArgb(255, 128, 0);
            btnOgrenciRaporu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgrenciRaporu.ForeColor = Color.White;
            btnOgrenciRaporu.Location = new Point(1040, 37);
            btnOgrenciRaporu.Margin = new Padding(3, 4, 3, 4);
            btnOgrenciRaporu.Name = "btnOgrenciRaporu";
            btnOgrenciRaporu.Size = new Size(226, 253);
            btnOgrenciRaporu.TabIndex = 2;
            btnOgrenciRaporu.Text = "Kayıtlı Öğrenci Raporu";
            btnOgrenciRaporu.UseVisualStyleBackColor = false;
            btnOgrenciRaporu.Click += btnOgrenciRaporu_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Maroon;
            btnCikisYap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnCikisYap.ForeColor = Color.White;
            btnCikisYap.Location = new Point(247, 485);
            btnCikisYap.Margin = new Padding(3, 4, 3, 4);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(795, 66);
            btnCikisYap.TabIndex = 3;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.BackColor = Color.Red;
            btnOgrenciSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgrenciSil.ForeColor = Color.White;
            btnOgrenciSil.Location = new Point(375, 37);
            btnOgrenciSil.Margin = new Padding(3, 4, 3, 4);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(215, 262);
            btnOgrenciSil.TabIndex = 4;
            btnOgrenciSil.Text = "Öğrenci Sil";
            btnOgrenciSil.UseVisualStyleBackColor = false;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // MemurAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 807);
            Controls.Add(btnOgrenciSil);
            Controls.Add(btnCikisYap);
            Controls.Add(btnOgrenciRaporu);
            Controls.Add(btnDersDuzenle);
            Controls.Add(btnOgrenciKayit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemurAnaForm";
            Text = "Öğrenci İşleri Memuru";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnDersDuzenle;
        private System.Windows.Forms.Button btnOgrenciRaporu;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnOgrenciSil;
    }
}
