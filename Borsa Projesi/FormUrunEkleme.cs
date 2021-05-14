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
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");

        private void urunKaydet()
        {
            bool onayDurumu = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urun (kullaniciadi,urunadi,urunmiktari,urunfiyati,onaydurumu) values ('" + label3.Text.ToString() + "' , '" + txtUrunAdi.Text.ToString() + "' , '" + txtUrunMiktari.Text.ToString() + "' , '" + txtUrunFiyatı.Text.ToString() + "' , '" + onayDurumu.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Başarıyla Eklendi! , Admin Tarafından Onaylanınca Ürünler Listesinde Görünecektir");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            urunKaydet();
        }

        private void FormUrunEkleme_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.gidenbilgi.ToString();
        }

        private void KisiGor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunKaydet();
            this.Close();
        }
    }
}
