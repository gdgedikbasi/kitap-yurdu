namespace KitapYurduDB
{
    partial class Form4
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
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblKitapID = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.btnStokDurumu = new System.Windows.Forms.Button();
            this.btnStokGuncelle = new System.Windows.Forms.Button();
            this.lblMevcutStok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(229, 38);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(153, 26);
            this.txtKitapID.TabIndex = 0;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(229, 100);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(153, 26);
            this.txtMiktar.TabIndex = 1;
            // 
            // lblKitapID
            // 
            this.lblKitapID.AutoSize = true;
            this.lblKitapID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapID.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblKitapID.Location = new System.Drawing.Point(140, 40);
            this.lblKitapID.Name = "lblKitapID";
            this.lblKitapID.Size = new System.Drawing.Size(83, 24);
            this.lblKitapID.TabIndex = 2;
            this.lblKitapID.Text = "Kitap ID:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblMiktar.Location = new System.Drawing.Point(68, 102);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(155, 24);
            this.lblMiktar.TabIndex = 3;
            this.lblMiktar.Text = "Miktar Değişikliği";
            // 
            // btnStokDurumu
            // 
            this.btnStokDurumu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStokDurumu.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokDurumu.ForeColor = System.Drawing.Color.White;
            this.btnStokDurumu.Location = new System.Drawing.Point(482, 38);
            this.btnStokDurumu.Name = "btnStokDurumu";
            this.btnStokDurumu.Size = new System.Drawing.Size(178, 88);
            this.btnStokDurumu.TabIndex = 4;
            this.btnStokDurumu.Text = "Stok Durumunu Göster";
            this.btnStokDurumu.UseVisualStyleBackColor = false;
            this.btnStokDurumu.Click += new System.EventHandler(this.btnStokDurumu_Click);
            // 
            // btnStokGuncelle
            // 
            this.btnStokGuncelle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStokGuncelle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnStokGuncelle.Location = new System.Drawing.Point(701, 38);
            this.btnStokGuncelle.Name = "btnStokGuncelle";
            this.btnStokGuncelle.Size = new System.Drawing.Size(186, 88);
            this.btnStokGuncelle.TabIndex = 5;
            this.btnStokGuncelle.Text = "Stok Güncelle";
            this.btnStokGuncelle.UseVisualStyleBackColor = false;
            this.btnStokGuncelle.Click += new System.EventHandler(this.btnStokGuncelle_Click);
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutStok.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblMevcutStok.Location = new System.Drawing.Point(699, 161);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(188, 24);
            this.lblMevcutStok.TabIndex = 6;
            this.lblMevcutStok.Text = "Mevcut Stok Durumu";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 650);
            this.Controls.Add(this.lblMevcutStok);
            this.Controls.Add(this.btnStokGuncelle);
            this.Controls.Add(this.btnStokDurumu);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblKitapID);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtKitapID);
            this.Name = "Form4";
            this.Text = "Stok Yönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblKitapID;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Button btnStokDurumu;
        private System.Windows.Forms.Button btnStokGuncelle;
        private System.Windows.Forms.Label lblMevcutStok;
    }
}