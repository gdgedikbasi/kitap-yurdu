namespace KitapYurduDB
{
    partial class Form2
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
            this.dataGridViewKullanici = new System.Windows.Forms.DataGridView();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapYurduDBDataSet = new KitapYurduDB.KitapYurduDBDataSet();
            this.kullaniciTableAdapter = new KitapYurduDB.KitapYurduDBDataSetTableAdapters.KullaniciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cmbKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.lblKullaniciTipi = new System.Windows.Forms.Label();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnToplamTutar = new System.Windows.Forms.Button();
            this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTableAdapter = new KitapYurduDB.KitapYurduDBDataSetTableAdapters.SiparisTableAdapter();
            this.siparisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSiparis = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKullanici
            // 
            this.dataGridViewKullanici.AutoGenerateColumns = false;
            this.dataGridViewKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.kullaniciTipiDataGridViewTextBoxColumn});
            this.dataGridViewKullanici.DataSource = this.kullaniciBindingSource;
            this.dataGridViewKullanici.Location = new System.Drawing.Point(0, 39);
            this.dataGridViewKullanici.Name = "dataGridViewKullanici";
            this.dataGridViewKullanici.RowHeadersWidth = 62;
            this.dataGridViewKullanici.RowTemplate.Height = 28;
            this.dataGridViewKullanici.Size = new System.Drawing.Size(656, 281);
            this.dataGridViewKullanici.TabIndex = 0;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            this.kullaniciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 150;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullaniciTipiDataGridViewTextBoxColumn
            // 
            this.kullaniciTipiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciTipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.HeaderText = "KullaniciTipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kullaniciTipiDataGridViewTextBoxColumn.Name = "kullaniciTipiDataGridViewTextBoxColumn";
            this.kullaniciTipiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.kitapYurduDBDataSet;
            // 
            // kitapYurduDBDataSet
            // 
            this.kitapYurduDBDataSet.DataSetName = "KitapYurduDBDataSet";
            this.kitapYurduDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(238, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Tablosu";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblAd.Location = new System.Drawing.Point(12, 335);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(120, 24);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Kullanıcı Adı:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblSoyad.Location = new System.Drawing.Point(12, 371);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(147, 24);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Kullanıcı Soyadı:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblEmail.Location = new System.Drawing.Point(12, 412);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(155, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Kullanıcı E-posta:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblSifre.Location = new System.Drawing.Point(12, 451);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(129, 24);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Kullanıcı Şifre:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(173, 335);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(131, 26);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(173, 371);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(131, 26);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 412);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(173, 451);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(131, 26);
            this.txtSifre.TabIndex = 9;
            // 
            // cmbKullaniciTipi
            // 
            this.cmbKullaniciTipi.FormattingEnabled = true;
            this.cmbKullaniciTipi.Location = new System.Drawing.Point(173, 495);
            this.cmbKullaniciTipi.Name = "cmbKullaniciTipi";
            this.cmbKullaniciTipi.Size = new System.Drawing.Size(131, 28);
            this.cmbKullaniciTipi.TabIndex = 10;
            // 
            // lblKullaniciTipi
            // 
            this.lblKullaniciTipi.AutoSize = true;
            this.lblKullaniciTipi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciTipi.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblKullaniciTipi.Location = new System.Drawing.Point(12, 495);
            this.lblKullaniciTipi.Name = "lblKullaniciTipi";
            this.lblKullaniciTipi.Size = new System.Drawing.Size(123, 24);
            this.lblKullaniciTipi.TabIndex = 11;
            this.lblKullaniciTipi.Text = "Kullanıcı Tipi:";
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKullaniciEkle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciEkle.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(16, 552);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(104, 96);
            this.btnKullaniciEkle.TabIndex = 12;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGetir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.White;
            this.btnGetir.Location = new System.Drawing.Point(173, 552);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(136, 96);
            this.btnGetir.TabIndex = 13;
            this.btnGetir.Text = "Kullanıcı Listesini Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnToplamTutar
            // 
            this.btnToplamTutar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnToplamTutar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplamTutar.ForeColor = System.Drawing.Color.White;
            this.btnToplamTutar.Location = new System.Drawing.Point(358, 552);
            this.btnToplamTutar.Name = "btnToplamTutar";
            this.btnToplamTutar.Size = new System.Drawing.Size(154, 96);
            this.btnToplamTutar.TabIndex = 14;
            this.btnToplamTutar.Text = "Toplam Sipariş Tutarını Göster ";
            this.btnToplamTutar.UseVisualStyleBackColor = false;
            this.btnToplamTutar.Click += new System.EventHandler(this.btnToplamTutar_Click);
            // 
            // dataGridViewSiparis
            // 
            this.dataGridViewSiparis.AutoGenerateColumns = false;
            this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisIDDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn1,
            this.siparisTarihiDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.siparisDurumuDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn});
            this.dataGridViewSiparis.DataSource = this.siparisBindingSource;
            this.dataGridViewSiparis.Location = new System.Drawing.Point(689, 39);
            this.dataGridViewSiparis.Name = "dataGridViewSiparis";
            this.dataGridViewSiparis.RowHeadersWidth = 62;
            this.dataGridViewSiparis.RowTemplate.Height = 28;
            this.dataGridViewSiparis.Size = new System.Drawing.Size(764, 281);
            this.dataGridViewSiparis.TabIndex = 15;
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
            // siparisIDDataGridViewTextBoxColumn
            // 
            this.siparisIDDataGridViewTextBoxColumn.DataPropertyName = "SiparisID";
            this.siparisIDDataGridViewTextBoxColumn.HeaderText = "SiparisID";
            this.siparisIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisIDDataGridViewTextBoxColumn.Name = "siparisIDDataGridViewTextBoxColumn";
            this.siparisIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.siparisIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullaniciIDDataGridViewTextBoxColumn1
            // 
            this.kullaniciIDDataGridViewTextBoxColumn1.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn1.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.kullaniciIDDataGridViewTextBoxColumn1.Name = "kullaniciIDDataGridViewTextBoxColumn1";
            this.kullaniciIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // siparisTarihiDataGridViewTextBoxColumn
            // 
            this.siparisTarihiDataGridViewTextBoxColumn.DataPropertyName = "SiparisTarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.HeaderText = "SiparisTarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisTarihiDataGridViewTextBoxColumn.Name = "siparisTarihiDataGridViewTextBoxColumn";
            this.siparisTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            this.toplamTutarDataGridViewTextBoxColumn.Width = 150;
            // 
            // siparisDurumuDataGridViewTextBoxColumn
            // 
            this.siparisDurumuDataGridViewTextBoxColumn.DataPropertyName = "SiparisDurumu";
            this.siparisDurumuDataGridViewTextBoxColumn.HeaderText = "SiparisDurumu";
            this.siparisDurumuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisDurumuDataGridViewTextBoxColumn.Name = "siparisDurumuDataGridViewTextBoxColumn";
            this.siparisDurumuDataGridViewTextBoxColumn.Width = 150;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // lblSiparis
            // 
            this.lblSiparis.AutoSize = true;
            this.lblSiparis.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparis.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblSiparis.Location = new System.Drawing.Point(1000, 12);
            this.lblSiparis.Name = "lblSiparis";
            this.lblSiparis.Size = new System.Drawing.Size(134, 24);
            this.lblSiparis.TabIndex = 16;
            this.lblSiparis.Text = "Sipariş Tablosu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(979, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 90);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sipariş Durumunu Kontrol Et";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSiparis);
            this.Controls.Add(this.dataGridViewSiparis);
            this.Controls.Add(this.btnToplamTutar);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Controls.Add(this.lblKullaniciTipi);
            this.Controls.Add(this.cmbKullaniciTipi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKullanici);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKullanici;
        private KitapYurduDBDataSet kitapYurduDBDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private KitapYurduDBDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.ComboBox cmbKullaniciTipi;
        private System.Windows.Forms.Label lblKullaniciTipi;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnToplamTutar;
        private System.Windows.Forms.DataGridView dataGridViewSiparis;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private KitapYurduDBDataSetTableAdapters.SiparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSiparis;
        private System.Windows.Forms.Button button1;
    }
}