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
    public partial class FormUrunEkleme : Form
    {
        public FormUrunEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SA7PU4L\\SQLEXPRESS;Initial Catalog=Borsa_Projesi;Integrated Security=True");

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string onayDurumu = "Hayır";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urunekleme (kullanıcıadı,ürünadı,ürünmiktarı,ürünfiyati,onaylanma) values ('" + label3.Text.ToString() + "' , '" + txtUrunAdi.Text.ToString() + "' , '" + txtUrunMiktari.Text.ToString() + "' , '" + txtUrunFiyatı.Text.ToString() + "' , '" + onayDurumu.ToString() + "')", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void FormUrunEkleme_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.gidenbilgi.ToString();
        }

        private void KisiGor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
