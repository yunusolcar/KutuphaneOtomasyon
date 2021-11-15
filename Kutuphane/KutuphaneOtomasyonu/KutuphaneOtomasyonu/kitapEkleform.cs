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
    public partial class kitapEkleform : Form
    {
        public kitapEkleform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7K9ONPQ\\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKtpIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKtpEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkod,kitapAdi,yazar,yayinevi,sayfasayisi,turu,stok,rafno,aciklama,kayitTarihi) values(@barkod,@kitapAdi,@yazar,@yayinevi,@sayfasayisi,@turu,@stok,@rafno,@aciklama,@kayitTarihi)",baglanti);
            komut.Parameters.AddWithValue("@barkod", textBarkod.Text);
            komut.Parameters.AddWithValue("@kitapAdi", textKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", textKitapYazari.Text);
            komut.Parameters.AddWithValue("@yayinevi", textYayınevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", textSayfa.Text);
            komut.Parameters.AddWithValue("@turu", comboTur.Text);
            komut.Parameters.AddWithValue("@stok", textStok.Text);
            komut.Parameters.AddWithValue("@rafno", textRaf.Text);
            komut.Parameters.AddWithValue("@aciklama", textAcıklama.Text);
            komut.Parameters.AddWithValue("@kayitTarihi",DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    

                        item.Text = "";
                    }

                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kitapEkleform_Load(object sender, EventArgs e)
        {

        }

        private void textBarkod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
