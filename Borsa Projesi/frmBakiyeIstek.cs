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
using System.Xml.Linq;

namespace Borsa_Projesi
{
    public partial class frmBakiyeIstek : Form
    {
        public frmBakiyeIstek()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");
        XDocument tcmbdoviz = XDocument.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

        int istenilenBakiye;
        decimal secilenKurBilgisi;
        decimal kurTutari;

        private void bakiyeGoster()
        {
            baglan.Open();
            SqlCommand komutBakiye = new SqlCommand("Select *From bakiye where kullaniciadi like '%" + lblKullanici.Text.ToString() + "%'", baglan);
            SqlDataReader oku = komutBakiye.ExecuteReader();
            oku.Read();
            lblBakiye.Text = oku["bakiye"].ToString();
            baglan.Close();
        }

        private void frmBakiyeIstek_Load(object sender, EventArgs e)
        {
            // Sistem Renkleri Oluşturuldu
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#03A9F4");

            btnBakiyeIste.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            btnKurBilgiCek.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            btnTutarOgren.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            lblKullanici.Text = frmGiris.gidenbilgi.ToString();       
            bakiyeGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool onayDurumu = false;
            int yuklenecekTutar;
            yuklenecekTutar = Convert.ToInt32(kurTutari);
            baglan.Open();
            SqlCommand komutBakiyeİste = new SqlCommand("insert into bakiyeistek (kullaniciadi, istekmiktari, onaydurumu) values ('" + lblKullanici.Text.ToString() + "' , '" + yuklenecekTutar.ToString() + "' , '" + onayDurumu.ToString() + "')",baglan);
            komutBakiyeİste.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bakiye isteğiniz oluşturuldu!");
            txtBakiyeIstek.Clear();
            
        }

        private void btnKurBilgiCek_Click(object sender, EventArgs e)
        {
            if(cmbKurlar.SelectedItem == "TÜRK LİRASI")
            {
                lblKurBilgisi.Text = string.Format("1.0000");
            }
            else
            {
                var kurbilgileri = from kurlar in tcmbdoviz.Descendants("Currency")
                                   where kurlar.Element("Isim").Value == cmbKurlar.Text
                                   select new
                                   {
                                       kuradiing = kurlar.Element("CurrencyName").Value,
                                       kuralis = kurlar.Element("ForexBuying").Value,
                                       kursatis = kurlar.Element("ForexSelling").Value
                                   };
                foreach (var veriler in kurbilgileri)
                {
                    lblKurBilgisi.Text = string.Format("{2:C}",
                        veriler.kuradiing, veriler.kuralis, veriler.kursatis);

                }
            }
            
        }

        private void btnTutarOgren_Click(object sender, EventArgs e)
        {
            istenilenBakiye = Convert.ToInt32(txtBakiyeIstek.Text);
            secilenKurBilgisi = Convert.ToDecimal(lblKurBilgisi.Text.Replace(".", ","));

            kurTutari = istenilenBakiye * secilenKurBilgisi;
            lblToplamTutar.Text = "Toplam Tutar : " + kurTutari.ToString();
        }
    }
}
