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
    public partial class frmUrunDetay : Form
    {
        public frmUrunDetay()
        {
            InitializeComponent();
        }

        int istenilenStok, kullanicibakiye;
        int stok, urunfiyati;
        int tutar;
        int saticiBakiye;
        String kullaniciadi;

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");
        String urunSecilen = FormUrunAl.secilenUrun.ToString();

        private void verilerigörüntüle()
        {
            baglan.Open();
            SqlCommand komutUrun = new SqlCommand("Select *From urun where urunadi like '%" + urunSecilen.ToString() + "%'", baglan);   
            SqlDataReader okuUrun = komutUrun.ExecuteReader();
            
            while (okuUrun.Read())
            {
                txtSaticiAdi.Text = okuUrun["kullaniciadi"].ToString();
                kullaniciadi = txtSaticiAdi.Text;
                txtUrunAdi.Text = okuUrun["urunadi"].ToString();
                txtStokMiktari.Text = okuUrun["urunmiktari"].ToString();
                stok = Int32.Parse(txtStokMiktari.Text);
                txtUrunFiyati.Text = okuUrun["urunfiyati"].ToString();
                urunfiyati = Int32.Parse(txtUrunFiyati.Text);
            }

            baglan.Close();

            saticiBakiyeOku();
        }

        void saticiBakiyeOku()
        {
            baglan.Open();
            SqlCommand saticiBakiyeKomut = new SqlCommand("Select *From bakiye where kullaniciadi like '%" + kullaniciadi.ToString() + "%'", baglan);
            SqlDataReader okuSaticiBakiye = saticiBakiyeKomut.ExecuteReader();
            okuSaticiBakiye.Read();
            saticiBakiye = Int32.Parse(okuSaticiBakiye["bakiye"].ToString());
            baglan.Close();
        }
        private void bakiyeGoster()
        {
            baglan.Open();
            SqlCommand bakiyeKomut = new SqlCommand("Select *From bakiye where kullaniciadi like '%" + lblAlanKullanici.Text.ToString() + "%'", baglan);
            SqlDataReader bakiyeOku = bakiyeKomut.ExecuteReader();
            bakiyeOku.Read();
            lblMevcutBakiye.Text = bakiyeOku["bakiye"].ToString();
            kullanicibakiye = Int32.Parse(lblMevcutBakiye.Text);
            baglan.Close();
        }

        void kontrolEt()
        {
            if(istenilenStok <= stok)
            {
                if(tutar <= kullanicibakiye)
                {
                    alimİslemi();
                    MessageBox.Show("Alım İşlemi Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Yetersiz Bakiye, Lütfen Ürün Almak İçin Bakiye Yükleyiniz!");
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Stok, Daha Fazla Ürün Almak İçin Satıcının Ürün Eklemesini Bekleyiniz!");
            }
        }

        void alimİslemi()
        {
            stok = stok - istenilenStok;
            kullanicibakiye = kullanicibakiye - tutar;

            baglan.Open();
            SqlCommand bakiyedenDus = new SqlCommand("Update bakiye set bakiye = '" + kullanicibakiye + "' where kullaniciadi = '" + lblAlanKullanici.Text.ToString() + "'", baglan);
            bakiyedenDus.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlCommand stoktanDus = new SqlCommand("Update urun set urunmiktari = '" + stok + "' where urunadi = '" + urunSecilen + "'", baglan);
            stoktanDus.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            saticiBakiye = saticiBakiye + tutar;
            SqlCommand saticiBakiyeEkle = new SqlCommand("Update bakiye set bakiye = '" + saticiBakiye + "' where kullaniciadi = '" + kullaniciadi.ToString() + "'", baglan);
            saticiBakiyeEkle.ExecuteNonQuery();
            baglan.Close();
        }
        
        private void frmUrunDetay_Load(object sender, EventArgs e)
        {
            // Sistem Renkleri Oluşturuldu
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#03A9F4");
            btnSatınAl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");

            verilerigörüntüle();
            lblAlanKullanici.Text = Form1.gidenbilgi.ToString();
            bakiyeGoster();
            
            lblMevcutBakiye.Text = kullanicibakiye.ToString();
        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            istenilenStok = Int32.Parse(txtIstenilenMiktar.Text);
            tutar = istenilenStok * urunfiyati;
            kontrolEt();
            verilerigörüntüle();
            bakiyeGoster();           
        }
    }
}
