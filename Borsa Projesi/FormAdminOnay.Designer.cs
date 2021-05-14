namespace Borsa_Projesi
{
    partial class FormAdminOnay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUrunOnayla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBakiyeOnayla = new System.Windows.Forms.Button();
            this.lstBakiyeOnay = new System.Windows.Forms.ListView();
            this.lstUrunOnay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstUrunOnay);
            this.groupBox1.Controls.Add(this.btnUrunOnayla);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Onaylanmayan Ürünler";
            // 
            // btnUrunOnayla
            // 
            this.btnUrunOnayla.Location = new System.Drawing.Point(808, 33);
            this.btnUrunOnayla.Name = "btnUrunOnayla";
            this.btnUrunOnayla.Size = new System.Drawing.Size(89, 36);
            this.btnUrunOnayla.TabIndex = 1;
            this.btnUrunOnayla.Text = "Onayla";
            this.btnUrunOnayla.UseVisualStyleBackColor = true;
            this.btnUrunOnayla.Click += new System.EventHandler(this.btnUrunOnayla_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBakiyeOnayla);
            this.groupBox2.Controls.Add(this.lstBakiyeOnay);
            this.groupBox2.Location = new System.Drawing.Point(12, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 318);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Onaylanmayan Bakiye";
            // 
            // btnBakiyeOnayla
            // 
            this.btnBakiyeOnayla.Location = new System.Drawing.Point(808, 33);
            this.btnBakiyeOnayla.Name = "btnBakiyeOnayla";
            this.btnBakiyeOnayla.Size = new System.Drawing.Size(89, 36);
            this.btnBakiyeOnayla.TabIndex = 1;
            this.btnBakiyeOnayla.Text = "Onayla";
            this.btnBakiyeOnayla.UseVisualStyleBackColor = true;
            // 
            // lstBakiyeOnay
            // 
            this.lstBakiyeOnay.HideSelection = false;
            this.lstBakiyeOnay.Location = new System.Drawing.Point(16, 33);
            this.lstBakiyeOnay.Name = "lstBakiyeOnay";
            this.lstBakiyeOnay.Size = new System.Drawing.Size(786, 262);
            this.lstBakiyeOnay.TabIndex = 1;
            this.lstBakiyeOnay.UseCompatibleStateImageBehavior = false;
            // 
            // lstUrunOnay
            // 
            this.lstUrunOnay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstUrunOnay.HideSelection = false;
            this.lstUrunOnay.Location = new System.Drawing.Point(16, 33);
            this.lstUrunOnay.Name = "lstUrunOnay";
            this.lstUrunOnay.Size = new System.Drawing.Size(786, 252);
            this.lstUrunOnay.TabIndex = 3;
            this.lstUrunOnay.UseCompatibleStateImageBehavior = false;
            this.lstUrunOnay.View = System.Windows.Forms.View.Details;
            this.lstUrunOnay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstUrunOnay_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat (kg)";
            this.columnHeader4.Width = 138;
            // 
            // FormAdminOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 702);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdminOnay";
            this.Text = "FormAdminOnay";
            this.Load += new System.EventHandler(this.FormAdminOnay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUrunOnayla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBakiyeOnayla;
        private System.Windows.Forms.ListView lstBakiyeOnay;
        private System.Windows.Forms.ListView lstUrunOnay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}