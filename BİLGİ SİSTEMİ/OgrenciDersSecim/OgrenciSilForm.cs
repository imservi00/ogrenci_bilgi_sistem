using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciDersSecim
{
    public partial class OgrenciSilForm : Form
    {
        public OgrenciSilForm()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int ogrenciID = int.Parse(txtOgrenciID.Text);

            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // KullaniciID'yi bulma
                string getKullaniciIDQuery = "SELECT KullaniciID FROM Ogrenci WHERE OgrenciID = @OgrenciID";
                SqlCommand cmdGetKullaniciID = new SqlCommand(getKullaniciIDQuery, conn);
                cmdGetKullaniciID.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                int kullaniciID = (int)cmdGetKullaniciID.ExecuteScalar();

                // İlk olarak, ilişkili OgrenciDers kayıtlarını silelim
                string deleteOgrenciDersQuery = "DELETE FROM OgrenciDers WHERE OgrenciID = @OgrenciID";
                SqlCommand cmdOgrenciDers = new SqlCommand(deleteOgrenciDersQuery, conn);
                cmdOgrenciDers.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                cmdOgrenciDers.ExecuteNonQuery();

                // Sonra, Ogrenci kaydını silelim
                string deleteOgrenciQuery = "DELETE FROM Ogrenci WHERE OgrenciID = @OgrenciID";
                SqlCommand cmdOgrenci = new SqlCommand(deleteOgrenciQuery, conn);
                cmdOgrenci.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                cmdOgrenci.ExecuteNonQuery();

                // Son olarak, Kullanici kaydını silelim
                string deleteKullaniciQuery = "DELETE FROM Kullanici WHERE KullaniciID = @KullaniciID";
                SqlCommand cmdKullanici = new SqlCommand(deleteKullaniciQuery, conn);
                cmdKullanici.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                cmdKullanici.ExecuteNonQuery();

                MessageBox.Show("Öğrenci başarıyla silindi!");
            }
        }
    }
}
