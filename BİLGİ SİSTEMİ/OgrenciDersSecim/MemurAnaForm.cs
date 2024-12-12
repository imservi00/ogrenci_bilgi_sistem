using System;
using System.Windows.Forms;

namespace OgrenciDersSecim
{
    public partial class MemurAnaForm : Form
    {
        public MemurAnaForm()
        {
            InitializeComponent();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            OgrenciKayitForm ogrenciKayitForm = new OgrenciKayitForm();
            ogrenciKayitForm.ShowDialog();
        }

        private void btnDersDuzenle_Click(object sender, EventArgs e)
        {
            DersDuzenleForm dersDuzenleForm = new DersDuzenleForm();
            dersDuzenleForm.ShowDialog();
        }

        private void btnOgrenciRaporu_Click(object sender, EventArgs e)
        {
            OgrenciRaporForm ogrenciRaporForm = new OgrenciRaporForm();
            ogrenciRaporForm.ShowDialog();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            OgrenciSilForm ogrenciSilForm = new OgrenciSilForm();
            ogrenciSilForm.ShowDialog();
        }
    }
}
