using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciDersSecim
{
    public partial class DanismanAnaForm : Form
    {
        private int danismanID;

        public DanismanAnaForm(int danismanID)
        {
            InitializeComponent();
            this.danismanID = danismanID;
            LoadOgrenciDersleri();
        }

        private void LoadOgrenciDersleri()
        {
            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT OgrenciDers.OgrenciID, Ogrenci.Ad, Ogrenci.Soyad, OgrenciDers.DersID, Ders.DersAdi, OgrenciDers.Durum " +
                               "FROM OgrenciDers " +
                               "INNER JOIN Ogrenci ON OgrenciDers.OgrenciID = Ogrenci.OgrenciID " +
                               "INNER JOIN Ders ON OgrenciDers.DersID = Ders.DersID " +
                               "WHERE OgrenciDers.Durum = 'Onay Bekliyor'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Debug için bulunan kayıt sayısını kontrol etme
                MessageBox.Show("Bulunan Kayıt Sayısı: " + dt.Rows.Count.ToString());

                dataGridViewOgrenciDersleri.DataSource = dt;
            }
        }



        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciDersleri.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOgrenciDersleri.SelectedRows[0];
                int ogrenciID = Convert.ToInt32(selectedRow.Cells["OgrenciID"].Value);
                int dersID = Convert.ToInt32(selectedRow.Cells["DersID"].Value);

                string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE OgrenciDers SET Durum = 'Onaylandı' WHERE OgrenciID = @OgrenciID AND DersID = @DersID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ders başarıyla onaylandı.");
                    LoadOgrenciDersleri();
                }
            }
            else
            {
                MessageBox.Show("Lütfen onaylamak istediğiniz dersi seçin.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciDersleri.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOgrenciDersleri.SelectedRows[0];
                int ogrenciID = Convert.ToInt32(selectedRow.Cells["OgrenciID"].Value);
                int dersID = Convert.ToInt32(selectedRow.Cells["DersID"].Value);

                string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE OgrenciDers SET Durum = 'Reddedildi' WHERE OgrenciID = @OgrenciID AND DersID = @DersID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.ExecuteNonQuery();

                    query = "UPDATE Ders SET Kontenjan = Kontenjan + 1 WHERE DersID = @DersID";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ders başarıyla reddedildi.");
                    LoadOgrenciDersleri();
                }
            }
            else
            {
                MessageBox.Show("Lütfen reddetmek istediğiniz dersi seçin.");
            }
        }
    }
}
