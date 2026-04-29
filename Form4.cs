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
    public partial class Form4 : Form
    {
        //veritabanı bağlantısı için
        private string connectionString = "Server=DESKTOP-NE6PH93\\SQLEXPRESS;Database=KitapYurduDB;Trusted_Connection=True;";
        public Form4()
        {
            InitializeComponent();
        }

        private void btnStokDurumu_Click(object sender, EventArgs e)
        {
            try
            {
                int kitapID = Convert.ToInt32(txtKitapID.Text);

                //KitapStokDurumu fonksiyonu burada kullanıldı
                string query = "SELECT dbo.KitapStokDurumu(@KitapID)";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KitapID", kitapID);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    int mevcutStok = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblMevcutStok.Text = $"Mevcut Stok: {mevcutStok}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok durumu sorgulanırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int kitapID = Convert.ToInt32(txtKitapID.Text);
                int miktarDegisimi = Convert.ToInt32(txtMiktar.Text);

                //StokGuncelle procedure'ü burada kullanıldı
                string query = "EXEC StokGuncelle @KitapID, @AdetDegisimi";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE6PH93\\SQLEXPRESS;Initial Catalog=KitapYurduDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KitapID", kitapID);
                    cmd.Parameters.AddWithValue("@AdetDegisimi", miktarDegisimi);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    int yeniStok = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblMevcutStok.Text = $"Yeni Stok: {yeniStok}";

                    MessageBox.Show("Stok başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok güncellenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
