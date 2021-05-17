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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {}

        private void btnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kullanici (ad,soyad,kullaniciadi,sifre,tcno,telefon,email,adres) values ('" + txtKayitAd.Text.ToString() + "', '" + txtKayitSoyad.Text.ToString() + "','" + txtKayitKullaniciad.Text.ToString() + "','" + txtKayitSifre.Text.ToString() + "' , '" + txtKayitTC.Text.ToString() + "' , '" + txtKayitTelefon.Text.ToString() + "' , '" + txtKayitMail.Text.ToString() + "' , '" + txtKayitAdres.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komutBakiye = new SqlCommand("insert into bakiye (kullaniciadi , bakiye) values ('" + txtKayitKullaniciad.Text.ToString() + "' ,'" + "0" + "')", baglanti);
            komutBakiye.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }

            MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur!");
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Sistem Renkleri Oluşturuldu
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#03A9F4");
            btnKayit.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
        }
    }
}
