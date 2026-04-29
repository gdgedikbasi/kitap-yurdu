namespace KitapYurduDB
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblKullaniciID = new System.Windows.Forms.Label();
            this.lblKitapID = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.btnSiparisDetay = new System.Windows.Forms.Button();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.cmbYeniDurum = new System.Windows.Forms.ComboBox();
            this.lblYeniDurum = new System.Windows.Forms.Label();
            this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
            this.kitapYurduDBDataSet = new KitapYurduDB.KitapYurduDBDataSet();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTableAdapter = new KitapYurduDB.KitapYurduDBDataSetTableAdapters.SiparisTableAdapter();
            this.siparisDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisDetayTableAdapter = new KitapYurduDB.KitapYurduDBDataSetTableAdapters.SiparisDetayTableAdapter();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnKategoriyeGoreListele = new System.Windows.Forms.Button();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapTableAdapter = new KitapYurduDB.KitapYurduDBDataSetTableAdapters.KitapTableAdapter();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(618, 261);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(100, 26);
            this.txtKullaniciID.TabIndex = 0;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(618, 298);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(100, 26);
            this.txtKitapID.TabIndex = 1;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(618, 334);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 26);
            this.txtAdet.TabIndex = 2;
            // 
            // lblKullaniciID
            // 
            this.lblKullaniciID.AutoSize = true;
            this.lblKullaniciID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciID.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblKullaniciID.Location = new System.Drawing.Point(499, 261);
            this.lblKullaniciID.Name = "lblKullaniciID";
            this.lblKullaniciID.Size = new System.Drawing.Size(110, 24);
            this.lblKullaniciID.TabIndex = 3;
            this.lblKullaniciID.Text = "Kullanıcı ID:";
            // 
            // lblKitapID
            // 
            this.lblKitapID.AutoSize = true;
            this.lblKitapID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapID.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblKitapID.Location = new System.Drawing.Point(499, 298);
            this.lblKitapID.Name = "lblKitapID";
            this.lblKitapID.Size = new System.Drawing.Size(83, 24);
            this.lblKitapID.TabIndex = 4;
            this.lblKitapID.Text = "Kitap ID:";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblAdet.Location = new System.Drawing.Point(487, 334);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(125, 24);
            this.lblAdet.TabIndex = 5;
            this.lblAdet.Text = "Sipariş Adedi:";
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.ForeColor = System.Drawing.Color.White;
            this.btnSiparisOlustur.Location = new System.Drawing.Point(503, 127);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(173, 67);
            this.btnSiparisOlustur.TabIndex = 6;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = false;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // btnSiparisDetay
            // 
            this.btnSiparisDetay.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSiparisDetay.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisDetay.ForeColor = System.Drawing.Color.White;
            this.btnSiparisDetay.Location = new System.Drawing.Point(722, 127);
            this.btnSiparisDetay.Name = "btnSiparisDetay";
            this.btnSiparisDetay.Size = new System.Drawing.Size(192, 67);
            this.btnSiparisDetay.TabIndex = 7;
            this.btnSiparisDetay.Text = "Sipariş Detaylarını Göster";
            this.btnSiparisDetay.UseVisualStyleBackColor = false;
            this.btnSiparisDetay.Click += new System.EventHandler(this.btnSiparisDetay_Click);
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDurumGuncelle.Location = new System.Drawing.Point(960, 126);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(172, 68);
            this.btnDurumGuncelle.TabIndex = 8;
            this.btnDurumGuncelle.Text = "Sipariş Durumu Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // cmbYeniDurum
            // 
            this.cmbYeniDurum.FormattingEnabled = true;
            this.cmbYeniDurum.Location = new System.Drawing.Point(618, 223);
            this.cmbYeniDurum.Name = "cmbYeniDurum";
            this.cmbYeniDurum.Size = new System.Drawing.Size(192, 28);
            this.cmbYeniDurum.TabIndex = 9;
            // 
            // lblYeniDurum
            // 
            this.lblYeniDurum.AutoSize = true;
            this.lblYeniDurum.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniDurum.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblYeniDurum.Location = new System.Drawing.Point(499, 223);
            this.lblYeniDurum.Name = "lblYeniDurum";
            this.lblYeniDurum.Size = new System.Drawing.Size(113, 24);
            this.lblYeniDurum.TabIndex = 10;
            this.lblYeniDurum.Text = "Yeni Durum:";
            // 
            // dataGridViewSiparis
            // 
            this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewSiparis.Name = "dataGridViewSiparis";
            this.dataGridViewSiparis.RowHeadersWidth = 62;
            this.dataGridViewSiparis.RowTemplate.Height = 28;
            this.dataGridViewSiparis.Size = new System.Drawing.Size(450, 212);
            this.dataGridViewSiparis.TabIndex = 11;
            // 
            // kitapYurduDBDataSet
            // 
            this.kitapYurduDBDataSet.DataSetName = "KitapYurduDBDataSet";
            this.kitapYurduDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "Siparis";
            this.siparisBindingSource.DataSource = this.kitapYurduDBDataSet;
            // 
            // siparisTableAdapter
            // 
            this.siparisTableAdapter.ClearBeforeFill = true;
            // 
            // siparisDetayBindingSource
            // 
            this.siparisDetayBindingSource.DataMember = "SiparisDetay";
            this.siparisDetayBindingSource.DataSource = this.kitapYurduDBDataSet;
            // 
            // siparisDetayTableAdapter
            // 
            this.siparisDetayTableAdapter.ClearBeforeFill = true;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(846, 422);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(192, 28);
            this.cmbKategoriler.TabIndex = 12;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblKategori.Location = new System.Drawing.Point(732, 422);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(108, 24);
            this.lblKategori.TabIndex = 13;
            this.lblKategori.Text = "Kategoriler:";
            // 
            // btnKategoriyeGoreListele
            // 
            this.btnKategoriyeGoreListele.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKategoriyeGoreListele.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriyeGoreListele.ForeColor = System.Drawing.Color.White;
            this.btnKategoriyeGoreListele.Location = new System.Drawing.Point(736, 478);
            this.btnKategoriyeGoreListele.Name = "btnKategoriyeGoreListele";
            this.btnKategoriyeGoreListele.Size = new System.Drawing.Size(143, 85);
            this.btnKategoriyeGoreListele.TabIndex = 14;
            this.btnKategoriyeGoreListele.Text = "Kategoriye Göre Listele";
            this.btnKategoriyeGoreListele.UseVisualStyleBackColor = false;
            this.btnKategoriyeGoreListele.Click += new System.EventHandler(this.btnKategoriyeGoreListele_Click);
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoGenerateColumns = false;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapIDDataGridViewTextBoxColumn,
            this.kategoriIDDataGridViewTextBoxColumn,
            this.baslikDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridViewKitaplar.DataSource = this.kitapBindingSource;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(27, 422);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowHeadersWidth = 62;
            this.dataGridViewKitaplar.RowTemplate.Height = 28;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(662, 150);
            this.dataGridViewKitaplar.TabIndex = 15;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kitapYurduDBDataSet;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            this.kitapIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            this.kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            this.kategoriIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // baslikDataGridViewTextBoxColumn
            // 
            this.baslikDataGridViewTextBoxColumn.DataPropertyName = "Baslik";
            this.baslikDataGridViewTextBoxColumn.HeaderText = "Baslik";
            this.baslikDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.baslikDataGridViewTextBoxColumn.Name = "baslikDataGridViewTextBoxColumn";
            this.baslikDataGridViewTextBoxColumn.Width = 150;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.Width = 150;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 150;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 660);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.Controls.Add(this.btnKategoriyeGoreListele);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.dataGridViewSiparis);
            this.Controls.Add(this.lblYeniDurum);
            this.Controls.Add(this.cmbYeniDurum);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.btnSiparisDetay);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblKitapID);
            this.Controls.Add(this.lblKullaniciID);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.txtKullaniciID);
            this.Name = "Form3";
            this.Text = "Sipariş Oluşturma Formu";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblKullaniciID;
        private System.Windows.Forms.Label lblKitapID;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.Button btnSiparisDetay;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.ComboBox cmbYeniDurum;
        private System.Windows.Forms.Label lblYeniDurum;
        private System.Windows.Forms.DataGridView dataGridViewSiparis;
        private KitapYurduDBDataSet kitapYurduDBDataSet;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private KitapYurduDBDataSetTableAdapters.SiparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.BindingSource siparisDetayBindingSource;
        private KitapYurduDBDataSetTableAdapters.SiparisDetayTableAdapter siparisDetayTableAdapter;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnKategoriyeGoreListele;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KitapYurduDBDataSetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
    }
}