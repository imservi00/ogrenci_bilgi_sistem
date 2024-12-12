namespace OgrenciDersSecim
{
    partial class DanismanAnaForm
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
            dataGridViewOgrenciDersleri = new DataGridView();
            btnOnayla = new Button();
            btnReddet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOgrenciDersleri
            // 
            dataGridViewOgrenciDersleri.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewOgrenciDersleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciDersleri.Location = new Point(262, 16);
            dataGridViewOgrenciDersleri.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOgrenciDersleri.Name = "dataGridViewOgrenciDersleri";
            dataGridViewOgrenciDersleri.RowHeadersWidth = 51;
            dataGridViewOgrenciDersleri.RowTemplate.Height = 24;
            dataGridViewOgrenciDersleri.Size = new Size(776, 500);
            dataGridViewOgrenciDersleri.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.Lime;
            btnOnayla.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOnayla.ForeColor = Color.White;
            btnOnayla.Location = new Point(494, 632);
            btnOnayla.Margin = new Padding(3, 4, 3, 4);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(101, 37);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnReddet
            // 
            btnReddet.BackColor = Color.Red;
            btnReddet.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnReddet.ForeColor = Color.White;
            btnReddet.Location = new Point(693, 632);
            btnReddet.Margin = new Padding(3, 4, 3, 4);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(101, 37);
            btnReddet.TabIndex = 2;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = false;
            btnReddet.Click += btnReddet_Click;
            // 
            // DanismanAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 807);
            Controls.Add(btnReddet);
            Controls.Add(btnOnayla);
            Controls.Add(dataGridViewOgrenciDersleri);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DanismanAnaForm";
            Text = "Danışman Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewOgrenciDersleri;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
    }
}
