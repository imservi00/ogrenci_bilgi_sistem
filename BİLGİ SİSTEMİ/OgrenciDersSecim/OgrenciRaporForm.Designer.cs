namespace OgrenciDersSecim
{
    partial class OgrenciRaporForm
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
            dataGridViewOgrenciler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Location = new Point(11, 15);
            dataGridViewOgrenciler.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.RowHeadersWidth = 51;
            dataGridViewOgrenciler.RowTemplate.Height = 24;
            dataGridViewOgrenciler.Size = new Size(1251, 777);
            dataGridViewOgrenciler.TabIndex = 0;
            // 
            // OgrenciRaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 808);
            Controls.Add(dataGridViewOgrenciler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgrenciRaporForm";
            Text = "Kayıtlı Öğrenci Raporu";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewOgrenciler;
    }
}
