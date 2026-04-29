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
    public partial class Form3 : Form
    {
        //veritabanı bağlantısı için
        private string connectionString = "Server=DESKTOP-NE6PH93\\SQLEXPRESS;Database=KitapYurduDB;Trusted_Connection=True;";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapYurduDBDataSet.Kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.kitapYurduDBDataSet.Kitap);
            // TODO: This line of code loads data into the 'kitapYurduDBDataSet.SiparisDetay' table. You can move, or remove it, as needed.
            this.siparisDetayTableAdapter.Fill(this.kitapYurduDBDataSet.SiparisDetay);
            // TODO: This line of code loads data into the 'kitapYurduDBDataSet.Siparis' table. You can move, or remove it, as needed.
            this.siparisTableAdapter.Fill(this.kitapYurduDBDataSet.Siparis);

            //Sipariş durumlarını ComboBox'a eklemek için
            cmbYeniDurum.Items.Add("Hazırlanıyor");
            cmbYeniDurum.Items.Add("Gönderildi");
            cmbYeniDurum.Items.Add("Teslim Edildi");
            cmbYeniDurum.SelectedIndex = -1; //Varsayılan olarak boş bırakmak için

            //cmbKategori çalışması için
            try
            {
                string query = "SELECT KategoriID, KategoriAdi FROM Kategori";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // ComboBox'a bağla
                    cmbKategoriler.DataSource = dt;
                    cmbKategoriler.DisplayMember = "KategoriAdi";
                    cmbKategoriler.ValueMember = "KategoriID";
                    cmbKategoriler.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategoriler yüklenemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //trg_SiparisLogEkle, trg_StokAzalt ve trg_TeslimTarihiGuncelle triggerları bu formda yazılan kodlarla
        //trigger'lanır.
        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                //SiparisOlustur procedure'ü burada kullanılır
                string query = "EXEC SiparisOlustur @KullaniciID, @KitapID, @Adet";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", Convert.ToInt32(txtKullaniciID.Text));
                    cmd.Parameters.AddWithValue("@KitapID", Convert.ToInt32(txtKitapID.Text));
                    cmd.Parameters.AddWithValue("@Adet", Convert.ToInt32(txtAdet.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sipariş başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Veritabanı hatası: {sqlEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiparisDetay_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT sp.SiparisID, sp.KullaniciID, sp.SiparisTarihi, sp.ToplamTutar, sp.SiparisDurumu, sd.KitapID, sd.Adet, sd.AraToplam " +
                               "FROM Siparis sp " +
                               "JOIN SiparisDetay sd ON sp.SiparisID = sd.SiparisID";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewSiparis.DataSource = null; //Eski verileri temizlemek için
                    dataGridViewSiparis.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş detayları getirilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSiparis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir sipariş seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int siparisID = Convert.ToInt32(dataGridViewSiparis.SelectedRows[0].Cells["SiparisID"].Value);
                string yeniDurum = cmbYeniDurum.SelectedItem.ToString();

                //SiparisDurumuGuncelle procedure'ü burada kullanılır
                string query = "EXEC SiparisDurumuGuncelle @SiparisID, @YeniDurum";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SiparisID", siparisID);
                    cmd.Parameters.AddWithValue("@YeniDurum", yeniDurum);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sipariş durumu başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKategoriyeGoreListele_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKategoriler.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir kategori seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Seçilen kategori ID'sini almak için
                int kategoriID = Convert.ToInt32(cmbKategoriler.SelectedValue);

                //KitaplariListele procedure'ü burada kullanılır
                string query = "EXEC KitaplariListele @KategoriID";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KategoriID", kategoriID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // DataGridView'e bağla
                    dataGridViewKitaplar.DataSource = null;
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
