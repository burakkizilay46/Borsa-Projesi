
namespace Borsa_Projesi
{
    partial class AnaSayfa
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
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunAl = new System.Windows.Forms.Button();
            this.btnYukle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(69, 86);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(327, 172);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "ÜRÜN SAT 💰\r\n";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunAl
            // 
            this.btnUrunAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAl.Location = new System.Drawing.Point(502, 86);
            this.btnUrunAl.Name = "btnUrunAl";
            this.btnUrunAl.Size = new System.Drawing.Size(327, 172);
            this.btnUrunAl.TabIndex = 1;
            this.btnUrunAl.Text = "ÜRÜN AL 🛒";
            this.btnUrunAl.UseVisualStyleBackColor = true;
            this.btnUrunAl.Click += new System.EventHandler(this.btnUrunAl_Click);
            // 
            // btnYukle
            // 
            this.btnYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.Location = new System.Drawing.Point(69, 456);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(327, 172);
            this.btnYukle.TabIndex = 7;
            this.btnYukle.Text = "BAKİYE YÜKLE 💸";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(502, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 172);
            this.button1.TabIndex = 8;
            this.button1.Text = "ÇIKIŞ ❌";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfil.Location = new System.Drawing.Point(290, 271);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(327, 172);
            this.btnProfil.TabIndex = 9;
            this.btnProfil.Text = "PROFİLİM 👤";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.btnUrunAl);
            this.Controls.Add(this.btnUrunEkle);
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunAl;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProfil;
    }
}