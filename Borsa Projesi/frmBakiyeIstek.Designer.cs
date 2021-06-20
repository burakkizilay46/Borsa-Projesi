namespace Borsa_Projesi
{
    partial class frmBakiyeIstek
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
            this.txtBakiyeIstek = new System.Windows.Forms.TextBox();
            this.btnBakiyeIste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKurlar = new System.Windows.Forms.ComboBox();
            this.btnKurBilgiCek = new System.Windows.Forms.Button();
            this.lblKurBilgisi = new System.Windows.Forms.Label();
            this.grpboxKur = new System.Windows.Forms.GroupBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnTutarOgren = new System.Windows.Forms.Button();
            this.grpboxKur.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBakiyeIstek
            // 
            this.txtBakiyeIstek.Location = new System.Drawing.Point(630, 238);
            this.txtBakiyeIstek.Name = "txtBakiyeIstek";
            this.txtBakiyeIstek.Size = new System.Drawing.Size(146, 22);
            this.txtBakiyeIstek.TabIndex = 0;
            // 
            // btnBakiyeIste
            // 
            this.btnBakiyeIste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiyeIste.Location = new System.Drawing.Point(39, 348);
            this.btnBakiyeIste.Name = "btnBakiyeIste";
            this.btnBakiyeIste.Size = new System.Drawing.Size(772, 48);
            this.btnBakiyeIste.TabIndex = 1;
            this.btnBakiyeIste.Text = "Bakiye Yükle";
            this.btnBakiyeIste.UseVisualStyleBackColor = true;
            this.btnBakiyeIste.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(138, 21);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(130, 29);
            this.lblKullanici.TabIndex = 3;
            this.lblKullanici.Text = "lblKullanici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mevcut Bakiye:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(213, 70);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(111, 29);
            this.lblBakiye.TabIndex = 5;
            this.lblBakiye.Text = "lblBakiye";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yüklemek İstediğiniz Bakiye Miktarını Giriniz:";
            // 
            // cmbKurlar
            // 
            this.cmbKurlar.FormattingEnabled = true;
            this.cmbKurlar.Items.AddRange(new object[] {
            "ABD DOLARI",
            "EURO",
            "İNGİLİZ STERLİNİ",
            "TÜRK LİRASI"});
            this.cmbKurlar.Location = new System.Drawing.Point(29, 37);
            this.cmbKurlar.Name = "cmbKurlar";
            this.cmbKurlar.Size = new System.Drawing.Size(208, 24);
            this.cmbKurlar.TabIndex = 7;
            // 
            // btnKurBilgiCek
            // 
            this.btnKurBilgiCek.Location = new System.Drawing.Point(290, 37);
            this.btnKurBilgiCek.Name = "btnKurBilgiCek";
            this.btnKurBilgiCek.Size = new System.Drawing.Size(105, 36);
            this.btnKurBilgiCek.TabIndex = 8;
            this.btnKurBilgiCek.Text = "Kur Bilgisi Al";
            this.btnKurBilgiCek.UseVisualStyleBackColor = true;
            this.btnKurBilgiCek.Click += new System.EventHandler(this.btnKurBilgiCek_Click);
            // 
            // lblKurBilgisi
            // 
            this.lblKurBilgisi.AutoSize = true;
            this.lblKurBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurBilgisi.Location = new System.Drawing.Point(24, 92);
            this.lblKurBilgisi.Name = "lblKurBilgisi";
            this.lblKurBilgisi.Size = new System.Drawing.Size(37, 29);
            this.lblKurBilgisi.TabIndex = 9;
            this.lblKurBilgisi.Text = "---";
            // 
            // grpboxKur
            // 
            this.grpboxKur.Controls.Add(this.cmbKurlar);
            this.grpboxKur.Controls.Add(this.lblKurBilgisi);
            this.grpboxKur.Controls.Add(this.btnKurBilgiCek);
            this.grpboxKur.Location = new System.Drawing.Point(390, 21);
            this.grpboxKur.Name = "grpboxKur";
            this.grpboxKur.Size = new System.Drawing.Size(421, 177);
            this.grpboxKur.TabIndex = 10;
            this.grpboxKur.TabStop = false;
            this.grpboxKur.Text = "Kur Seç";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(34, 274);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(332, 33);
            this.lblToplamTutar.TabIndex = 11;
            this.lblToplamTutar.Text = "Toplam Tutar : ---";
            // 
            // btnTutarOgren
            // 
            this.btnTutarOgren.Location = new System.Drawing.Point(630, 274);
            this.btnTutarOgren.Name = "btnTutarOgren";
            this.btnTutarOgren.Size = new System.Drawing.Size(149, 36);
            this.btnTutarOgren.TabIndex = 10;
            this.btnTutarOgren.Text = "Tutar Bilgisi";
            this.btnTutarOgren.UseVisualStyleBackColor = true;
            this.btnTutarOgren.Click += new System.EventHandler(this.btnTutarOgren_Click);
            // 
            // frmBakiyeIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 408);
            this.Controls.Add(this.btnTutarOgren);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.grpboxKur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBakiyeIste);
            this.Controls.Add(this.txtBakiyeIstek);
            this.Name = "frmBakiyeIstek";
            this.Text = "Bakiye İstek";
            this.Load += new System.EventHandler(this.frmBakiyeIstek_Load);
            this.grpboxKur.ResumeLayout(false);
            this.grpboxKur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBakiyeIstek;
        private System.Windows.Forms.Button btnBakiyeIste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKurlar;
        private System.Windows.Forms.Button btnKurBilgiCek;
        private System.Windows.Forms.Label lblKurBilgisi;
        private System.Windows.Forms.GroupBox grpboxKur;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnTutarOgren;
    }
}