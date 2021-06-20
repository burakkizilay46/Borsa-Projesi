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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Borsa_Projesi
{
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");
        string kullaniciAdi;
        string ad, soyad, sifre, tcno, telefon, email, adres;

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream(@"C:\Users\burak\Desktop\urunlerim.pdf", FileMode.Create));

            document.Open();

            int kolonSayisi = (lstKullaniciUrunler.Columns.Count);
            PdfPTable table = new PdfPTable(kolonSayisi);
            table.SpacingBefore = 10f;
            table.DefaultCell.Phrase = new Phrase() {};
            table.WidthPercentage = 100f;

            for (int j = 0; j < kolonSayisi; j++)
            {
                table.AddCell(new Phrase(lstKullaniciUrunler.Columns[j].Text));
            }

            foreach (ListViewItem item in lstKullaniciUrunler.Items)
            {
                for (int i = 0; i < lstKullaniciUrunler.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(item.SubItems[i].Text));
                }
            }

            document.Add(table);
            MessageBox.Show("Raporunuz Oluşturuldu! Erişmek için Masaüstüne Gidiniz!");
            document.Close();
        }


        private void kullaniciVerileriGoruntule()
        {
            baglan.Open();
            SqlCommand komutKullanici = new SqlCommand("Select *From kullanici where kullaniciAdi like '%" + kullaniciAdi.ToString() + "%'", baglan);
            SqlDataReader okuKullanici = komutKullanici.ExecuteReader();

            while (okuKullanici.Read())
            {
                
                ad = okuKullanici["ad"].ToString();
                soyad = okuKullanici["soyad"].ToString();
                sifre = okuKullanici["sifre"].ToString();
                tcno = okuKullanici["tcno"].ToString();
                telefon = okuKullanici["telefon"].ToString();
                email = okuKullanici["email"].ToString();
                adres = okuKullanici["adres"].ToString();

                lblKullaniciBilgileri.Text = "Kullanici Bilgileri \n-------------------------\n" + 
                    "Kullanici Adi : " + kullaniciAdi.ToString() + "\n" + 
                    "Ad : " + ad.ToString() + "\n" + 
                    "Soyad : " + soyad.ToString() + "\n" + 
                    "Sifre : " + sifre.ToString() + "\n" + 
                    "TC No : " + tcno.ToString() + "\n" +
                    "Telefon : " + telefon.ToString() + "\n" +
                    "Email : " + email.ToString() + "\n" +
                    "Adres : " + adres.ToString() + "\n" ;
            }

            baglan.Close();
        }

        private void urunVerileriGoruntule()
        {
            lstKullaniciUrunler.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From urun where kullaniciadi like '%" + kullaniciAdi + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                
                ekle.Text = (oku["urunadi"].ToString());
                ekle.SubItems.Add(oku["urunmiktari"].ToString());
                ekle.SubItems.Add(oku["urunfiyati"].ToString());
                ekle.SubItems.Add (oku["onaydurumu"].ToString());

                lstKullaniciUrunler.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void frmProfil_Load(object sender, EventArgs e)
        {
            kullaniciAdi = frmGiris.gidenbilgi.ToString(); ;
            kullaniciVerileriGoruntule();
            urunVerileriGoruntule();
        }
    }
}
