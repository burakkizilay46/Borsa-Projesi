using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa_Projesi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public string kullaniciAdi { get; set; }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkleme FrmUrun = new FormUrunEkleme();
            FrmUrun.Show();
        }

        private void btnUrunAl_Click(object sender, EventArgs e)
        {
            FormUrunAl FrmUrunAl = new FormUrunAl();
            FrmUrunAl.Show();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            FormAdminOnay adminPage = new FormAdminOnay();
            adminPage.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            // Sistem Renkleri Oluşturuldu
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#03A9F4");
            btnUrunAl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            btnUrunEkle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            btnYukle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            btnProfil.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            frmBakiyeIstek bakiyeyukle = new frmBakiyeIstek();
            bakiyeyukle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfil frmProfilSayfasi = new frmProfil();
            frmProfilSayfasi.Show();
        }
    }
}
