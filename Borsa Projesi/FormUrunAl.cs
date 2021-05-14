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
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SA7PU4L\\SQLEXPRESS;Initial Catalog=Borsa_Projesi;Integrated Security=True");

        private void verilerigörüntüle()
        {
            LstStok.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From urunekleme", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullanıcıadı"].ToString();
                ekle.SubItems.Add(oku["ürünadı"].ToString());
                ekle.SubItems.Add(oku["ürünmiktarı"].ToString());
                ekle.SubItems.Add(oku["ürünfiyati"].ToString());
                ekle.SubItems.Add(oku["onaylanma"].ToString());

                LstStok.Items.Add(ekle);
            }
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
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into urunsatma (bakiye) values ('" + txtBakiye.Text.ToString() + "')", baglan);



            komut.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
