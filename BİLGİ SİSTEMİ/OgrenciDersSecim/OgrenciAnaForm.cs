using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciDersSecim
{
    public partial class OgrenciAnaForm : Form
    {
        private int ogrenciID;
        private int toplamKredi = 0;
        private float gano = 0;

        public OgrenciAnaForm(int ogrenciID)
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
            LoadGano();
            LoadDersData();
            LoadOgrenciDersleri();
        }

        private void LoadGano()
        {
            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Gano FROM Ogrenci WHERE KullaniciID = @OgrenciID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                gano = Convert.ToSingle(cmd.ExecuteScalar());
            }
        }

        private void LoadDersData()
        {
            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DersID, DersAdi, Kredi, Kontenjan, Aktif FROM Ders WHERE Aktif = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDersler.DataSource = dt;
            }
        }

        private void LoadOgrenciDersleri()
        {
            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT OgrenciDers.DersID, Ders.DersAdi, Ders.Kredi, OgrenciDers.Durum FROM OgrenciDers INNER JOIN Ders ON OgrenciDers.DersID = Ders.DersID WHERE OgrenciID = @OgrenciID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                toplamKredi = 0; // Reset kredi to avoid double counting
                foreach (DataRow row in dt.Rows)
                {
                    toplamKredi += Convert.ToInt32(row["Kredi"]);
                }

                lblKrediToplam.Text = "Toplam Kredi: " + toplamKredi.ToString();
                dataGridViewOgrenciDersleri.DataSource = dt;
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (dataGridViewDersler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDersler.SelectedRows[0];
                int dersID = Convert.ToInt32(selectedRow.Cells["DersID"].Value);
                int kredi = Convert.ToInt32(selectedRow.Cells["Kredi"].Value);
                int kontenjan = Convert.ToInt32(selectedRow.Cells["Kontenjan"].Value);

                if (kontenjan <= 0)
                {
                    MessageBox.Show("Seçilen dersin kontenjanı dolmuştur.");
                    return;
                }

                int krediSiniri = gano >= 3.0 ? 30 : 21;
                if (toplamKredi + kredi > krediSiniri)
                {
                    MessageBox.Show("Toplam kredi sınırını aştınız.");
                    return;
                }

                string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO OgrenciDers (OgrenciID, DersID, Durum) VALUES (@OgrenciID, @DersID, 'Beklemede')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.ExecuteNonQuery();

                    toplamKredi += kredi;
                    lblKrediToplam.Text = "Toplam Kredi: " + toplamKredi.ToString();

                    query = "UPDATE Ders SET Kontenjan = Kontenjan - 1 WHERE DersID = @DersID";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ders başarıyla eklendi ve danışman onayı bekleniyor.");
                    LoadDersData();
                    LoadOgrenciDersleri();
                }
            }
            else
            {
                MessageBox.Show("Lütfen eklemek istediğiniz dersi seçin.");
            }
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciDersleri.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOgrenciDersleri.SelectedRows[0];
                int dersID = Convert.ToInt32(selectedRow.Cells["DersID"].Value);
                int kredi = Convert.ToInt32(selectedRow.Cells["Kredi"].Value);

                string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM OgrenciDers WHERE OgrenciID = @OgrenciID AND DersID = @DersID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.ExecuteNonQuery();

                    toplamKredi -= kredi;
                    lblKrediToplam.Text = "Toplam Kredi: " + toplamKredi.ToString();

                    query = "UPDATE Ders SET Kontenjan = Kontenjan + 1 WHERE DersID = @DersID";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ders başarıyla silindi.");
                    LoadDersData();
                    LoadOgrenciDersleri();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersi seçin.");
            }
        }

        private void btnDanismanaGonder_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE OgrenciDers SET Durum = 'Onay Bekliyor' WHERE OgrenciID = @OgrenciID AND Durum = 'Beklemede'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Seçimler danışmana gönderildi.");
                LoadOgrenciDersleri();
            }
        }
    }
}
