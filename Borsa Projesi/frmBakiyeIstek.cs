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
    public partial class frmBakiyeIstek : Form
    {
        public frmBakiyeIstek()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4UMSCIK;Initial Catalog=kullanici;Integrated Security=True");

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
            // Hex Kodu
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#03A9F4");
            btnBakiyeIste.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFC107");
            lblKullanici.Text = Form1.gidenbilgi.ToString();
            bakiyeGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool onayDurumu = false;
            int istenilenBakiye;
            istenilenBakiye = Int32.Parse(txtBakiyeIstek.Text);
            baglan.Open();
            SqlCommand komutBakiyeİste = new SqlCommand("insert into bakiyeistek (kullaniciadi, istekmiktari, onaydurumu) values ('" + lblKullanici.Text.ToString() + "' , '" + istenilenBakiye.ToString() + "' , '" + onayDurumu.ToString() + "')",baglan);
            komutBakiyeİste.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bakiye isteğiniz oluşturuldu!");
            txtBakiyeIstek.Clear();
        }
    }
}
