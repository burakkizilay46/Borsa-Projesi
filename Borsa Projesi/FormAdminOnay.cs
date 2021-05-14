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
    public partial class FormAdminOnay : Form
    {
        public FormAdminOnay()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");
        private void urunVerileriniGörüntüle()
        {
            lstUrunOnay.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From urun where onaydurumu like '%" + "False" + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullaniciadi"].ToString();
                ekle.SubItems.Add(oku["urunadi"].ToString());
                ekle.SubItems.Add(oku["urunmiktari"].ToString());
                ekle.SubItems.Add(oku["urunfiyati"].ToString());



                lstUrunOnay.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void FormAdminOnay_Load(object sender, EventArgs e)
        {
            urunVerileriniGörüntüle();
        }

        String secilenUrun;
        private void btnUrunOnayla_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand urunOnayla = new SqlCommand("Update urun set onaydurumu = '" + "True" + "' where urunadi = '" + secilenUrun.ToString() + "'", baglan);
            urunOnayla.ExecuteNonQuery();
            baglan.Close();
            urunVerileriniGörüntüle();
        }

        private void lstUrunOnay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secilenUrun = lstUrunOnay.SelectedItems[0].SubItems[1].Text;
        }
    }
}
