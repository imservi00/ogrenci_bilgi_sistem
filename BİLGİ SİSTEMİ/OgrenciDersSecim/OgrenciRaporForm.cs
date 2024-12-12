using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciDersSecim
{
    public partial class OgrenciRaporForm : Form
    {
        public OgrenciRaporForm()
        {
            InitializeComponent();
            LoadOgrenciData();
        }

        private void LoadOgrenciData()
        {
            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Ogrenci.OgrenciID, Ogrenci.Ad, Ogrenci.Soyad, Ogrenci.Gano, Danisman.Ad AS DanismanAd, Danisman.Soyad AS DanismanSoyad FROM Ogrenci INNER JOIN Danisman ON Ogrenci.DanismanID = Danisman.DanismanID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOgrenciler.DataSource = dt;
            }
        }
    }
}
