using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapYurduDB
{
    public partial class Form1 : Form
    {
        //veritabanı bağlantısı için
        private string connectionString = "Server=DESKTOP-NE6PH93\\SQLEXPRESS;Database=KitapYurduDB;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            Form2 kullaniciForm = new Form2();
            kullaniciForm.Show();
        }

        private void btnSiparisYonetimi_Click(object sender, EventArgs e)
        {
            Form3 siparisForm = new Form3();
            siparisForm.Show();
        }

        private void btnStokYonetimi_Click(object sender, EventArgs e)
        {
            Form4 stokForm = new Form4();
            stokForm.Show();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            Form5 raporlamaForm = new Form5();
            raporlamaForm.Show();
        }
    }
}
