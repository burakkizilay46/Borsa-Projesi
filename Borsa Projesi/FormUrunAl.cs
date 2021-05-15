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
    public partial class FormUrunAl : Form
    {
        public FormUrunAl()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");
        int bakiye = 0;

        private void verilerigörüntüle()
        {
            LstStok.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From urun where onaydurumu like '%"+ "True" +"%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullaniciadi"].ToString();
                ekle.SubItems.Add(oku["urunadi"].ToString());
                ekle.SubItems.Add(oku["urunmiktari"].ToString());     
                ekle.SubItems.Add(oku["urunfiyati"].ToString());

                

                LstStok.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void bakiyeGoster()
        {
            baglan.Open();
            SqlCommand komutBakiye = new SqlCommand("Select *From bakiye where kullaniciadi like '%" + lblKullaniciAdi.Text.ToString() + "%'", baglan);
            SqlDataReader oku = komutBakiye.ExecuteReader();
            oku.Read();
            lblBakiye.Text = oku["bakiye"].ToString();
            baglan.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            frmBakiyeIstek bakiyeIstek = new frmBakiyeIstek();
            bakiyeIstek.Show();
           // int eklenecekBakiye = Int32.Parse(txtBakiye.Text);
           // bakiye += eklenecekBakiye;
           // baglan.Open();
           // SqlCommand bakiyeGuncelle = new SqlCommand("Update bakiye set bakiye = '" + bakiye.ToString()+ "' where kullaniciadi = '" + lblKullaniciAdi.Text.ToString() + "'", baglan);
           // bakiyeGuncelle.ExecuteNonQuery();
           // baglan.Close();
           //
           // txtBakiye.Clear();
           // bakiyeGoster();
        }

        private void FormUrunAl_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = Form1.gidenbilgi.ToString();
            bakiyeGoster();
            bakiye = Int32.Parse(lblBakiye.Text);
        }
    }
}
