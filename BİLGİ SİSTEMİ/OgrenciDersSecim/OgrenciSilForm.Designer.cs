namespace OgrenciDersSecim
{
    partial class OgrenciSilForm
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
            txtOgrenciID = new TextBox();
            btnSil = new Button();
            lblOgrenciID = new Label();
            SuspendLayout();
            // 
            // txtOgrenciID
            // 
            txtOgrenciID.Location = new Point(564, 192);
            txtOgrenciID.Margin = new Padding(3, 4, 3, 4);
            txtOgrenciID.Name = "txtOgrenciID";
            txtOgrenciID.Size = new Size(263, 27);
            txtOgrenciID.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(589, 355);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 145);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lblOgrenciID
            // 
            lblOgrenciID.AutoSize = true;
            lblOgrenciID.Location = new Point(468, 195);
            lblOgrenciID.Name = "lblOgrenciID";
            lblOgrenciID.Size = new Size(83, 20);
            lblOgrenciID.TabIndex = 2;
            lblOgrenciID.Text = "Öğrenci ID:";
            // 
            // OgrenciSilForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 807);
            Controls.Add(lblOgrenciID);
            Controls.Add(btnSil);
            Controls.Add(txtOgrenciID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgrenciSilForm";
            Text = "Öğrenci Sil";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblOgrenciID;
    }
}
