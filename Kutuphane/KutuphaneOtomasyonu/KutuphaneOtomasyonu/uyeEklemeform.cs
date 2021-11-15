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

namespace KutuphaneOtomasyonu
{
    public partial class uyeEklemeform : Form
    {
        public uyeEklemeform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7K9ONPQ\\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,adsoyad,yas,cinsiyet,telefon,adres,mail,okuduguktp)" +
                "values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@mail,@okuduguktp)", baglanti);
            komut.Parameters.AddWithValue("@tc",textTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", textAdsoyad.Text);
            komut.Parameters.AddWithValue("@yas", textYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", textTelefon.Text);
            komut.Parameters.AddWithValue("@adres", textAdres.Text);
            komut.Parameters.AddWithValue("@mail", textMail.Text);
            komut.Parameters.AddWithValue("@okuduguktp", textOkudugu.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
            foreach(Control item in Controls)
            {
                if(item is TextBox){
                    if (item!=textOkudugu)
                    {
                        item.Text = "";
                    }
                   
                }
            }
        }

        private void uyeEklemeform_Load(object sender, EventArgs e)
        {

        }
    }
}
