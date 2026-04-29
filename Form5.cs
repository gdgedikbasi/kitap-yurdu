using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapYurduDB
{
    public partial class Form5 : Form
    {
        //veritabanı bağlantısı için
        private string connectionString = "Server=DESKTOP-NE6PH93\\SQLEXPRESS;Database=KitapYurduDB;Trusted_Connection=True;";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapYurduDBDataSet.SiparisYonetimView' table. You can move, or remove it, as needed.
            this.siparisYonetimViewTableAdapter.Fill(this.kitapYurduDBDataSet.SiparisYonetimView);
            try
            {
                string query = "SELECT * FROM SiparisYonetimView";

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //DataGridView'e bağlamak için
                    dataGridViewRapor.DataSource = null;
                    dataGridViewRapor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //cmbFiltre için yazdığım kod
            try
            {
                //Filtre seçeneklerini eklemek için
                cmbFiltre.Items.Add("Tüm Siparişler");
                cmbFiltre.Items.Add("Hazırlanıyor");
                cmbFiltre.Items.Add("Gönderildi");
                cmbFiltre.Items.Add("Teslim Edildi");
                cmbFiltre.SelectedIndex = 0; //Varsayılan seçim

                //Tüm siparişleri yüklemek için
                LoadSiparisData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadSiparisData()
        {
            try
            {
                //SiparisYonetimView view'i burada kullanılır
                string query = "SELECT * FROM SiparisYonetimView";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRapor.DataSource = null;
                    dataGridViewRapor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tüm siparişler yüklenemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSiparisRaporu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtpBaslangicTarihi.Value;

                //SiparisYonetimView view'i burada kullanılır
                string query = "SELECT * FROM SiparisYonetimView WHERE SiparisTarihi >= @BaslangicTarihi";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRapor.DataSource = null;
                    dataGridViewRapor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş raporu getirilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStokRaporu_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT KitapID, Adet AS MevcutStok, SonGuncelleme FROM Stok WHERE Adet < 5";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRapor.DataSource = null;
                    dataGridViewRapor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kritik stok raporu getirilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKullaniciRaporu_Click(object sender, EventArgs e)
        {
            try
            {
                //Tüm detaylı bilgileri çeken sorgu
                string query = "SELECT k.KullaniciID, k.Ad AS KullaniciAdi, k.Soyad AS KullaniciSoyadi, k.Email AS KullaniciEmail, " +
                       "sp.SiparisID, sp.SiparisTarihi, sp.TeslimTarihi, sp.ToplamTutar AS SiparisToplamTutari, " +
                       "sd.KitapID, kt.Baslik AS KitapBaslik, kt.Yazar AS KitapYazar, " +
                       "sd.Adet AS SiparisAdedi, sd.AraToplam AS KitapAraToplam, " +
                       "s.Adet AS MevcutStok " +
                       "FROM Kullanici k " +
                       "JOIN Siparis sp ON k.KullaniciID = sp.KullaniciID " +
                       "JOIN SiparisDetay sd ON sp.SiparisID = sd.SiparisID " +
                       "JOIN Kitap kt ON sd.KitapID = kt.KitapID " +
                       "LEFT JOIN Stok s ON kt.KitapID = s.KitapID " +
                       "ORDER BY sp.SiparisTarihi DESC";

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //DataGridView'e bağlamak için
                    dataGridViewRapor.DataSource = null;
                    dataGridViewRapor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"En çok sipariş veren raporu getirilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cmbFiltre.SelectedItem.ToString();

            try
            {
                string query;

                if (selectedFilter == "Tüm Siparişler")
                {
                    query = "SELECT * FROM SiparisYonetimView";
                }
                else
                {
                    query = "SELECT * FROM SiparisYonetimView WHERE SiparisDurumu = @Durum";
                }

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (selectedFilter != "Tüm Siparişler")
                    {
                        cmd.Parameters.AddWithValue("@Durum", selectedFilter);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRapor.DataSource = null;
                    dataGridViewRapor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtreleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
