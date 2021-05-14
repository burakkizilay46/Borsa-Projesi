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
    public partial class Form1 : Form
    {
        public static string gidenbilgi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Giris Yapildi");
                AnaSayfa Asayfa = new AnaSayfa();
                Asayfa.Show();
                this.Hide();
                
            }
            else if( "admin" == txtKullaniciAdi.Text && "admin" == txtSifre.Text)
            {
                MessageBox.Show("Giris Yapildi");
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
        {

        }
    }
}
