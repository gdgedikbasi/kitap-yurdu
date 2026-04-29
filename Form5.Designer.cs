namespace KitapYurduDB
{
    partial class Form5
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
            this.dataGridViewRapor = new System.Windows.Forms.DataGridView();
            this.kitapYurduDBDataSet = new KitapYurduDB.KitapYurduDBDataSet();
            this.siparisYonetimViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisYonetimViewTableAdapter = new KitapYurduDB.KitapYurduDBDataSetTableAdapters.SiparisYonetimViewTableAdapter();
            this.siparisNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBaslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAraToplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisToplamTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimEdildiMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mevcutStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiparisRaporu = new System.Windows.Forms.Button();
            this.btnStokRaporu = new System.Windows.Forms.Button();
            this.btnKullaniciRaporu = new System.Windows.Forms.Button();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisYonetimViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRapor
            // 
            this.dataGridViewRapor.AutoGenerateColumns = false;
            this.dataGridViewRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisNumarasiDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.kullaniciSoyadiDataGridViewTextBoxColumn,
            this.kullaniciEmailDataGridViewTextBoxColumn,
            this.kitapIDDataGridViewTextBoxColumn,
            this.kitapBaslikDataGridViewTextBoxColumn,
            this.kitapYazarDataGridViewTextBoxColumn,
            this.siparisAdediDataGridViewTextBoxColumn,
            this.kitapAraToplamDataGridViewTextBoxColumn,
            this.siparisToplamTutariDataGridViewTextBoxColumn,
            this.siparisDurumuDataGridViewTextBoxColumn,
            this.teslimEdildiMiDataGridViewCheckBoxColumn,
            this.mevcutStokDataGridViewTextBoxColumn,
            this.siparisTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn});
            this.dataGridViewRapor.DataSource = this.siparisYonetimViewBindingSource;
            this.dataGridViewRapor.Location = new System.Drawing.Point(1, 57);
            this.dataGridViewRapor.Name = "dataGridViewRapor";
            this.dataGridViewRapor.RowHeadersWidth = 62;
            this.dataGridViewRapor.RowTemplate.Height = 28;
            this.dataGridViewRapor.Size = new System.Drawing.Size(1468, 230);
            this.dataGridViewRapor.TabIndex = 0;
            // 
            // kitapYurduDBDataSet
            // 
            this.kitapYurduDBDataSet.DataSetName = "KitapYurduDBDataSet";
            this.kitapYurduDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisYonetimViewBindingSource
            // 
            this.siparisYonetimViewBindingSource.DataMember = "SiparisYonetimView";
            this.siparisYonetimViewBindingSource.DataSource = this.kitapYurduDBDataSet;
            // 
            // siparisYonetimViewTableAdapter
            // 
            this.siparisYonetimViewTableAdapter.ClearBeforeFill = true;
            // 
            // siparisNumarasiDataGridViewTextBoxColumn
            // 
            this.siparisNumarasiDataGridViewTextBoxColumn.DataPropertyName = "SiparisNumarasi";
            this.siparisNumarasiDataGridViewTextBoxColumn.HeaderText = "SiparisNumarasi";
            this.siparisNumarasiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisNumarasiDataGridViewTextBoxColumn.Name = "siparisNumarasiDataGridViewTextBoxColumn";
            this.siparisNumarasiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            this.kullaniciIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullaniciSoyadiDataGridViewTextBoxColumn
            // 
            this.kullaniciSoyadiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciSoyadi";
            this.kullaniciSoyadiDataGridViewTextBoxColumn.HeaderText = "KullaniciSoyadi";
            this.kullaniciSoyadiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kullaniciSoyadiDataGridViewTextBoxColumn.Name = "kullaniciSoyadiDataGridViewTextBoxColumn";
            this.kullaniciSoyadiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullaniciEmailDataGridViewTextBoxColumn
            // 
            this.kullaniciEmailDataGridViewTextBoxColumn.DataPropertyName = "KullaniciEmail";
            this.kullaniciEmailDataGridViewTextBoxColumn.HeaderText = "KullaniciEmail";
            this.kullaniciEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kullaniciEmailDataGridViewTextBoxColumn.Name = "kullaniciEmailDataGridViewTextBoxColumn";
            this.kullaniciEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            this.kitapIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // kitapBaslikDataGridViewTextBoxColumn
            // 
            this.kitapBaslikDataGridViewTextBoxColumn.DataPropertyName = "KitapBaslik";
            this.kitapBaslikDataGridViewTextBoxColumn.HeaderText = "KitapBaslik";
            this.kitapBaslikDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kitapBaslikDataGridViewTextBoxColumn.Name = "kitapBaslikDataGridViewTextBoxColumn";
            this.kitapBaslikDataGridViewTextBoxColumn.Width = 150;
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            this.kitapYazarDataGridViewTextBoxColumn.Width = 150;
            // 
            // siparisAdediDataGridViewTextBoxColumn
            // 
            this.siparisAdediDataGridViewTextBoxColumn.DataPropertyName = "SiparisAdedi";
            this.siparisAdediDataGridViewTextBoxColumn.HeaderText = "SiparisAdedi";
            this.siparisAdediDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisAdediDataGridViewTextBoxColumn.Name = "siparisAdediDataGridViewTextBoxColumn";
            this.siparisAdediDataGridViewTextBoxColumn.Width = 150;
            // 
            // kitapAraToplamDataGridViewTextBoxColumn
            // 
            this.kitapAraToplamDataGridViewTextBoxColumn.DataPropertyName = "KitapAraToplam";
            this.kitapAraToplamDataGridViewTextBoxColumn.HeaderText = "KitapAraToplam";
            this.kitapAraToplamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kitapAraToplamDataGridViewTextBoxColumn.Name = "kitapAraToplamDataGridViewTextBoxColumn";
            this.kitapAraToplamDataGridViewTextBoxColumn.Width = 150;
            // 
            // siparisToplamTutariDataGridViewTextBoxColumn
            // 
            this.siparisToplamTutariDataGridViewTextBoxColumn.DataPropertyName = "SiparisToplamTutari";
            this.siparisToplamTutariDataGridViewTextBoxColumn.HeaderText = "SiparisToplamTutari";
            this.siparisToplamTutariDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisToplamTutariDataGridViewTextBoxColumn.Name = "siparisToplamTutariDataGridViewTextBoxColumn";
            this.siparisToplamTutariDataGridViewTextBoxColumn.Width = 150;
            // 
            // siparisDurumuDataGridViewTextBoxColumn
            // 
            this.siparisDurumuDataGridViewTextBoxColumn.DataPropertyName = "SiparisDurumu";
            this.siparisDurumuDataGridViewTextBoxColumn.HeaderText = "SiparisDurumu";
            this.siparisDurumuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisDurumuDataGridViewTextBoxColumn.Name = "siparisDurumuDataGridViewTextBoxColumn";
            this.siparisDurumuDataGridViewTextBoxColumn.Width = 150;
            // 
            // teslimEdildiMiDataGridViewCheckBoxColumn
            // 
            this.teslimEdildiMiDataGridViewCheckBoxColumn.DataPropertyName = "TeslimEdildiMi";
            this.teslimEdildiMiDataGridViewCheckBoxColumn.HeaderText = "TeslimEdildiMi";
            this.teslimEdildiMiDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.teslimEdildiMiDataGridViewCheckBoxColumn.Name = "teslimEdildiMiDataGridViewCheckBoxColumn";
            this.teslimEdildiMiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.teslimEdildiMiDataGridViewCheckBoxColumn.Width = 150;
            // 
            // mevcutStokDataGridViewTextBoxColumn
            // 
            this.mevcutStokDataGridViewTextBoxColumn.DataPropertyName = "MevcutStok";
            this.mevcutStokDataGridViewTextBoxColumn.HeaderText = "MevcutStok";
            this.mevcutStokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mevcutStokDataGridViewTextBoxColumn.Name = "mevcutStokDataGridViewTextBoxColumn";
            this.mevcutStokDataGridViewTextBoxColumn.ReadOnly = true;
            this.mevcutStokDataGridViewTextBoxColumn.Width = 150;
            // 
            // siparisTarihiDataGridViewTextBoxColumn
            // 
            this.siparisTarihiDataGridViewTextBoxColumn.DataPropertyName = "SiparisTarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.HeaderText = "SiparisTarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siparisTarihiDataGridViewTextBoxColumn.Name = "siparisTarihiDataGridViewTextBoxColumn";
            this.siparisTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(238, 334);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(236, 26);
            this.dtpBaslangicTarihi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(13, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihini Giriniz:";
            // 
            // btnSiparisRaporu
            // 
            this.btnSiparisRaporu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSiparisRaporu.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisRaporu.ForeColor = System.Drawing.Color.White;
            this.btnSiparisRaporu.Location = new System.Drawing.Point(17, 398);
            this.btnSiparisRaporu.Name = "btnSiparisRaporu";
            this.btnSiparisRaporu.Size = new System.Drawing.Size(126, 128);
            this.btnSiparisRaporu.TabIndex = 3;
            this.btnSiparisRaporu.Text = "Sipariş Raporu Göster";
            this.btnSiparisRaporu.UseVisualStyleBackColor = false;
            this.btnSiparisRaporu.Click += new System.EventHandler(this.btnSiparisRaporu_Click);
            // 
            // btnStokRaporu
            // 
            this.btnStokRaporu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStokRaporu.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokRaporu.ForeColor = System.Drawing.Color.White;
            this.btnStokRaporu.Location = new System.Drawing.Point(185, 398);
            this.btnStokRaporu.Name = "btnStokRaporu";
            this.btnStokRaporu.Size = new System.Drawing.Size(129, 128);
            this.btnStokRaporu.TabIndex = 4;
            this.btnStokRaporu.Text = "Kritik Stok Raporu Göster";
            this.btnStokRaporu.UseVisualStyleBackColor = false;
            this.btnStokRaporu.Click += new System.EventHandler(this.btnStokRaporu_Click);
            // 
            // btnKullaniciRaporu
            // 
            this.btnKullaniciRaporu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKullaniciRaporu.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciRaporu.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciRaporu.Location = new System.Drawing.Point(350, 398);
            this.btnKullaniciRaporu.Name = "btnKullaniciRaporu";
            this.btnKullaniciRaporu.Size = new System.Drawing.Size(146, 128);
            this.btnKullaniciRaporu.TabIndex = 5;
            this.btnKullaniciRaporu.Text = "En Çok Sipariş Veren Kullanıcılar";
            this.btnKullaniciRaporu.UseVisualStyleBackColor = false;
            this.btnKullaniciRaporu.Click += new System.EventHandler(this.btnKullaniciRaporu_Click);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Location = new System.Drawing.Point(922, 330);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(204, 28);
            this.cmbFiltre.TabIndex = 6;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiltre.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblFiltre.Location = new System.Drawing.Point(589, 334);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(304, 24);
            this.lblFiltre.TabIndex = 7;
            this.lblFiltre.Text = "Kullanıcı veya kitap filtreleme ekle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(589, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "SiparisYonetimView";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.btnKullaniciRaporu);
            this.Controls.Add(this.btnStokRaporu);
            this.Controls.Add(this.btnSiparisRaporu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.dataGridViewRapor);
            this.Name = "Form5";
            this.Text = "Rapor Formu";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapYurduDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisYonetimViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRapor;
        private KitapYurduDBDataSet kitapYurduDBDataSet;
        private System.Windows.Forms.BindingSource siparisYonetimViewBindingSource;
        private KitapYurduDBDataSetTableAdapters.SiparisYonetimViewTableAdapter siparisYonetimViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBaslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAraToplamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisToplamTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn teslimEdildiMiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevcutStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiparisRaporu;
        private System.Windows.Forms.Button btnStokRaporu;
        private System.Windows.Forms.Button btnKullaniciRaporu;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Label label2;
    }
}