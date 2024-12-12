using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciDersSecim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string rol = cmbRol.SelectedItem.ToString();

            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT KullaniciID, Rol FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre AND Rol = @Rol";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                cmd.Parameters.AddWithValue("@Rol", rol);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int kullaniciID = (int)reader["KullaniciID"];
                    reader.Close();

                    if (rol == "Ogrenci")
                    {
                        OgrenciAnaForm ogrenciAnaForm = new OgrenciAnaForm(kullaniciID);
                        ogrenciAnaForm.Show();
                    }
                    else if (rol == "Memur")
                    {
                        MemurAnaForm memurAnaForm = new MemurAnaForm();
                        memurAnaForm.Show();
                    }
                    else if (rol == "Danisman")
                    {
                        DanismanAnaForm danismanAnaForm = new DanismanAnaForm(kullaniciID);
                        danismanAnaForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý, þifre veya rol yanlýþ.");
                }
            }
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
