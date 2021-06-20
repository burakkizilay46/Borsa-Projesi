using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Borsa_Projesi
{
    public partial class frmGiris : Form
    {
        public static string gidenbilgi = "";
        public frmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sistem Renkleri Oluşturuldu
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#03A9F4");
            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            btnGiris.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage pageLogin = new LoginPage();
            pageLogin.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string userName = txtKullaniciAdi.Text;
            string password = txtSifre.Text;

            con = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where kullaniciadi = '" + txtKullaniciAdi.Text + "' AND sifre='" + txtSifre.Text.ToString() + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa Asayfa = new AnaSayfa();
                Asayfa.Show();
                this.Hide();
                
            }
            else if( "admin" == txtKullaniciAdi.Text && "admin" == txtSifre.Text)
            {
                FormAdminOnay admin = new FormAdminOnay();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yalnış Kullanici Adi veya Sifre!");
            }
            con.Close();

            gidenbilgi = txtKullaniciAdi.Text;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {}
    }
}
