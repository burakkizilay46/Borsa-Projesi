namespace Borsa_Projesi
{
    partial class frmProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKullaniciBilgileri = new System.Windows.Forms.Label();
            this.lstKullaniciUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUrunlerim = new System.Windows.Forms.Label();
            this.btnRaporAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblKullaniciBilgileri
            // 
            this.lblKullaniciBilgileri.AutoSize = true;
            this.lblKullaniciBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciBilgileri.Location = new System.Drawing.Point(270, 12);
            this.lblKullaniciBilgileri.Name = "lblKullaniciBilgileri";
            this.lblKullaniciBilgileri.Size = new System.Drawing.Size(151, 25);
            this.lblKullaniciBilgileri.TabIndex = 1;
            this.lblKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // lstKullaniciUrunler
            // 
            this.lstKullaniciUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstKullaniciUrunler.HideSelection = false;
            this.lstKullaniciUrunler.Location = new System.Drawing.Point(12, 329);
            this.lstKullaniciUrunler.Name = "lstKullaniciUrunler";
            this.lstKullaniciUrunler.Size = new System.Drawing.Size(915, 298);
            this.lstKullaniciUrunler.TabIndex = 2;
            this.lstKullaniciUrunler.UseCompatibleStateImageBehavior = false;
            this.lstKullaniciUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adı";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Miktarı";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun Fiyatı";
            this.columnHeader3.Width = 206;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Onay Durumu";
            this.columnHeader4.Width = 212;
            // 
            // lblUrunlerim
            // 
            this.lblUrunlerim.AutoSize = true;
            this.lblUrunlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunlerim.Location = new System.Drawing.Point(12, 291);
            this.lblUrunlerim.Name = "lblUrunlerim";
            this.lblUrunlerim.Size = new System.Drawing.Size(119, 31);
            this.lblUrunlerim.TabIndex = 3;
            this.lblUrunlerim.Text = "Urunlerim";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Location = new System.Drawing.Point(737, 637);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(190, 47);
            this.btnRaporAl.TabIndex = 4;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // frmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 696);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.lblUrunlerim);
            this.Controls.Add(this.lstKullaniciUrunler);
            this.Controls.Add(this.lblKullaniciBilgileri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmProfil";
            this.Text = "Profilim";
            this.Load += new System.EventHandler(this.frmProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKullaniciBilgileri;
        private System.Windows.Forms.ListView lstKullaniciUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblUrunlerim;
        private System.Windows.Forms.Button btnRaporAl;
    }
}