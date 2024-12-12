using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciDersSecim
{
    public partial class DersDuzenleForm : Form
    {
        public DersDuzenleForm()
        {
            InitializeComponent();
            LoadDersData();
        }

        private void LoadDersData()
        {
            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Ders";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDersler.DataSource = dt;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string dersAdi = txtDersAdi.Text;
            int kredi = int.Parse(txtKredi.Text);
            int kontenjan = int.Parse(txtKontenjan.Text);
            int dersID = int.Parse(txtDersID.Text);
            bool aktif = chkAktif.Checked;

            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Ders SET DersAdi = @DersAdi, Kredi = @Kredi, Kontenjan = @Kontenjan, Aktif = @Aktif WHERE DersID = @DersID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DersAdi", dersAdi);
                cmd.Parameters.AddWithValue("@Kredi", kredi);
                cmd.Parameters.AddWithValue("@Kontenjan", kontenjan);
                cmd.Parameters.AddWithValue("@Aktif", aktif);
                cmd.Parameters.AddWithValue("@DersID", dersID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ders başarıyla güncellendi!");
                LoadDersData();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dersID = int.Parse(txtDersID.Text);

            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Ders WHERE DersID = @DersID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DersID", dersID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ders başarıyla silindi!");
                LoadDersData();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string dersAdi = txtDersAdi.Text;
            int kredi = int.Parse(txtKredi.Text);
            int kontenjan = int.Parse(txtKontenjan.Text);
            bool aktif = chkAktif.Checked;

            string connectionString = "Data Source=DESKTOP-TVLOELV;Initial Catalog=OgrenciDersSecim;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Ders (DersAdi, Kredi, Kontenjan, Aktif) VALUES (@DersAdi, @Kredi, @Kontenjan, @Aktif)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DersAdi", dersAdi);
                cmd.Parameters.AddWithValue("@Kredi", kredi);
                cmd.Parameters.AddWithValue("@Kontenjan", kontenjan);
                cmd.Parameters.AddWithValue("@Aktif", aktif);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ders başarıyla eklendi!");
                LoadDersData();
            }
        }

        private void dataGridViewDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDersler.Rows[e.RowIndex];
                txtDersID.Text = row.Cells["DersID"].Value.ToString();
                txtDersAdi.Text = row.Cells["DersAdi"].Value.ToString();
                txtKredi.Text = row.Cells["Kredi"].Value.ToString();
                txtKontenjan.Text = row.Cells["Kontenjan"].Value.ToString();
                chkAktif.Checked = Convert.ToBoolean(row.Cells["Aktif"].Value);
            }
        }
    }
}
