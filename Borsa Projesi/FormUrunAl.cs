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

        private void fiyataGoreVerileriGoruntule()
        {
            int fiyat;
            fiyat = Int32.Parse(txtBelirliFiyat.Text);

            LstStok.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From urun where urunfiyati like '%" + fiyat.ToString() + "%'", baglan);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            frmBakiyeIstek bakiyeIstek = new frmBakiyeIstek();
            bakiyeIstek.Show();
        }

        private void FormUrunAl_Load(object sender, EventArgs e)
        {
            // Sistem Renkleri Oluşturuldu
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#03A9F4");
            btnYenile.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            verilerigörüntüle();
        }
        
        public static String secilenUrun;
        private void LstStok_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secilenUrun = LstStok.SelectedItems[0].SubItems[1].Text;
            frmUrunDetay urunDetay = new frmUrunDetay();
            urunDetay.Show();
        }

        private void btnFiyataGore_Click(object sender, EventArgs e)
        {
            fiyataGoreVerileriGoruntule();
        }
    }
}
