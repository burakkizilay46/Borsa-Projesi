
namespace Borsa_Projesi
{
    partial class FormUrunAl
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
            this.LstStok = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblFiyatBelirleme = new System.Windows.Forms.Label();
            this.txtBelirliFiyat = new System.Windows.Forms.TextBox();
            this.btnFiyataGore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstStok
            // 
            this.LstStok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LstStok.HideSelection = false;
            this.LstStok.Location = new System.Drawing.Point(69, 203);
            this.LstStok.Name = "LstStok";
            this.LstStok.Size = new System.Drawing.Size(803, 463);
            this.LstStok.TabIndex = 0;
            this.LstStok.UseCompatibleStateImageBehavior = false;
            this.LstStok.View = System.Windows.Forms.View.Details;
            this.LstStok.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.LstStok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstStok_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat (kg)";
            this.columnHeader4.Width = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(269, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SATIN ALINABİLECEK ÜRÜNLER";
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(663, 683);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(209, 55);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFiyatBelirleme
            // 
            this.lblFiyatBelirleme.AutoSize = true;
            this.lblFiyatBelirleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatBelirleme.Location = new System.Drawing.Point(85, 89);
            this.lblFiyatBelirleme.Name = "lblFiyatBelirleme";
            this.lblFiyatBelirleme.Size = new System.Drawing.Size(422, 25);
            this.lblFiyatBelirleme.TabIndex = 3;
            this.lblFiyatBelirleme.Text = "Belirlemek İstediğiniz Fiyat Bilgisini Giriniz:";
            // 
            // txtBelirliFiyat
            // 
            this.txtBelirliFiyat.Location = new System.Drawing.Point(585, 92);
            this.txtBelirliFiyat.Name = "txtBelirliFiyat";
            this.txtBelirliFiyat.Size = new System.Drawing.Size(287, 22);
            this.txtBelirliFiyat.TabIndex = 4;
            // 
            // btnFiyataGore
            // 
            this.btnFiyataGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyataGore.Location = new System.Drawing.Point(663, 120);
            this.btnFiyataGore.Name = "btnFiyataGore";
            this.btnFiyataGore.Size = new System.Drawing.Size(209, 55);
            this.btnFiyataGore.TabIndex = 5;
            this.btnFiyataGore.Text = "Ara";
            this.btnFiyataGore.UseVisualStyleBackColor = true;
            this.btnFiyataGore.Click += new System.EventHandler(this.btnFiyataGore_Click);
            // 
            // FormUrunAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 751);
            this.Controls.Add(this.btnFiyataGore);
            this.Controls.Add(this.txtBelirliFiyat);
            this.Controls.Add(this.lblFiyatBelirleme);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstStok);
            this.Name = "FormUrunAl";
            this.Text = "Satın Alma Sayfası";
            this.Load += new System.EventHandler(this.FormUrunAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstStok;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblFiyatBelirleme;
        private System.Windows.Forms.TextBox txtBelirliFiyat;
        private System.Windows.Forms.Button btnFiyataGore;
    }
}