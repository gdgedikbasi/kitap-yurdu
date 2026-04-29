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
    public partial class Form2 : Form
    {
        //veritabanı bağlantısı için
        private string connectionString = "Server=DESKTOP-NE6PH93\\SQLEXPRESS;Database=KitapYurduDB;Trusted_Connection=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapYurduDBDataSet.Siparis' table. You can move, or remove it, as needed.
            this.siparisTableAdapter.Fill(this.kitapYurduDBDataSet.Siparis);
            // TODO: This line of code loads data into the 'kitapYurduDBDataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.kitapYurduDBDataSet.Kullanici);
            cmbKullaniciTipi.Items.Add("Müşteri");
            cmbKullaniciTipi.Items.Add("Satıcı");
            cmbKullaniciTipi.Items.Add("Admin");
            

        }

        
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (cmbKullaniciTipi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kullanıcı tipi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //KullaniciEkle procedure burada kullanılır
                string query = "EXEC KullaniciEkle @Ad, @Soyad, @Email, @Sifre, @KullaniciTipi";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@KullaniciTipi", cmbKullaniciTipi.SelectedItem.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı başarıyla eklendi!");
                    ClearFields(); //Alanları temizlemek için
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //Kullanıcı ekleme sonrası alanları temizlemek için
        private void ClearFields()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtSifre.Clear();
            cmbKullaniciTipi.SelectedIndex = -1;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT KullaniciID, Ad, Soyad, Email, KullaniciTipi FROM Kullanici";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewKullanici.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnToplamTutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewKullanici.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçin.");
                    return;
                }

                //Seçili kullanıcının ID'sini almak için
                int kullaniciID = Convert.ToInt32(dataGridViewKullanici.SelectedRows[0].Cells["KullaniciID"].Value);

                //KullaniciToplamSiparisTutari fonksiyonu kullanıldı
                string query = "SELECT dbo.KullaniciToplamSiparisTutari(@KullaniciID)";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    decimal toplamTutar = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    MessageBox.Show($"Seçilen Kullanıcının Toplam Sipariş Tutarı: {toplamTutar} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSiparisDurumuKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSiparis.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir sipariş seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Seçilen SiparisID'yi almak için
                int siparisID = Convert.ToInt32(dataGridViewSiparis.SelectedRows[0].Cells["SiparisID"].Value);

                //SiparisTeslimEdildiMi fonksiyonu burada kullanılır
                string query = "SELECT dbo.SiparisTeslimEdildiMi(@SiparisID)";
                using (SqlConnection conn = new SqlConnection("Data Source=SERVER_NAME;Initial Catalog=DATABASE_NAME;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SiparisID", siparisID);

                    conn.Open();
                    bool teslimEdildiMi = Convert.ToBoolean(cmd.ExecuteScalar());

                    // Durumu kullanıcıya göster
                    if (teslimEdildiMi)
                    {
                        MessageBox.Show("Seçilen sipariş teslim edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Seçilen sipariş henüz teslim edilmemiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
