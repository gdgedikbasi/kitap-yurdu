namespace KitapYurduDB
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.btnSiparisYonetimi = new System.Windows.Forms.Button();
            this.btnStokYonetimi = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(249, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Yurdu Yönetim Sistemi";
            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKullaniciYonetimi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(353, 144);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(121, 62);
            this.btnKullaniciYonetimi.TabIndex = 1;
            this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.UseVisualStyleBackColor = false;
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
            // 
            // btnSiparisYonetimi
            // 
            this.btnSiparisYonetimi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSiparisYonetimi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnSiparisYonetimi.Location = new System.Drawing.Point(353, 226);
            this.btnSiparisYonetimi.Name = "btnSiparisYonetimi";
            this.btnSiparisYonetimi.Size = new System.Drawing.Size(121, 63);
            this.btnSiparisYonetimi.TabIndex = 2;
            this.btnSiparisYonetimi.Text = "Sipariş Yönetimi";
            this.btnSiparisYonetimi.UseVisualStyleBackColor = false;
            this.btnSiparisYonetimi.Click += new System.EventHandler(this.btnSiparisYonetimi_Click);
            // 
            // btnStokYonetimi
            // 
            this.btnStokYonetimi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStokYonetimi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnStokYonetimi.Location = new System.Drawing.Point(353, 313);
            this.btnStokYonetimi.Name = "btnStokYonetimi";
            this.btnStokYonetimi.Size = new System.Drawing.Size(121, 64);
            this.btnStokYonetimi.TabIndex = 3;
            this.btnStokYonetimi.Text = "Stok Yönetimi";
            this.btnStokYonetimi.UseVisualStyleBackColor = false;
            this.btnStokYonetimi.Click += new System.EventHandler(this.btnStokYonetimi_Click);
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRaporlama.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlama.ForeColor = System.Drawing.Color.White;
            this.btnRaporlama.Location = new System.Drawing.Point(353, 401);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(121, 66);
            this.btnRaporlama.TabIndex = 4;
            this.btnRaporlama.Text = "Raporlama";
            this.btnRaporlama.UseVisualStyleBackColor = false;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 525);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnStokYonetimi);
            this.Controls.Add(this.btnSiparisYonetimi);
            this.Controls.Add(this.btnKullaniciYonetimi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kitap Yurdu Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
        private System.Windows.Forms.Button btnSiparisYonetimi;
        private System.Windows.Forms.Button btnStokYonetimi;
        private System.Windows.Forms.Button btnRaporlama;
    }
}

