using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciDersSecim
{
    public partial class OgrenciKayitForm : Form
    {
        public OgrenciKayitForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            float gano = float.Parse(txtGano.Text); // GANO bilgisi
            int danismanID = 1; // Sabit danışman ID

            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Kullanici (KullaniciAdi, Sifre, Rol) VALUES (@KullaniciAdi, @Sifre, 'Ogrenci'); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int kullaniciId))
                {
                    query = "INSERT INTO Ogrenci (KullaniciID, Ad, Soyad, Gano, DanismanID) VALUES (@KullaniciID, @Ad, @Soyad, @Gano, @DanismanID)";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Gano", gano);
                    cmd.Parameters.AddWithValue("@DanismanID", danismanID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Öğrenci başarıyla eklendi!");
                }
                else
                {
                    MessageBox.Show("Kullanıcı kaydı sırasında bir hata oluştu.");
                }
            }
        }
    }
}
