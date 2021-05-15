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
            this.SuspendLayout();
            // 
            // txtBakiyeIstek
            // 
            this.txtBakiyeIstek.Location = new System.Drawing.Point(179, 227);
            this.txtBakiyeIstek.Name = "txtBakiyeIstek";
            this.txtBakiyeIstek.Size = new System.Drawing.Size(146, 22);
            this.txtBakiyeIstek.TabIndex = 0;
            // 
            // btnBakiyeIste
            // 
            this.btnBakiyeIste.Location = new System.Drawing.Point(389, 220);
            this.btnBakiyeIste.Name = "btnBakiyeIste";
            this.btnBakiyeIste.Size = new System.Drawing.Size(144, 37);
            this.btnBakiyeIste.TabIndex = 1;
            this.btnBakiyeIste.Text = "Bakiye Yükle";
            this.btnBakiyeIste.UseVisualStyleBackColor = true;
            this.btnBakiyeIste.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(138, 26);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(178, 36);
            this.lblKullanici.TabIndex = 3;
            this.lblKullanici.Text = "lblKullanici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mevcut Bakiye:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(213, 75);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(120, 29);
            this.lblBakiye.TabIndex = 5;
            this.lblBakiye.Text = "lblBakiye";
            // 
            // frmBakiyeIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBakiyeIste);
            this.Controls.Add(this.txtBakiyeIstek);
            this.Name = "frmBakiyeIstek";
            this.Text = "frmBakiyeIstek";
            this.Load += new System.EventHandler(this.frmBakiyeIstek_Load);
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
    }
}