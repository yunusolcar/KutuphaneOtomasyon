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
    public partial class uyeListeform : Form
    {
        public uyeListeform()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7K9ONPQ\\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        private void textTc_TextChanged(object sender, EventArgs e)
        { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uye where tc like '"+textTc.Text+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textAdsoyad.Text = oku["adsoyad"].ToString();
                textYas.Text = oku["yas"].ToString();
                comboCinsiyet.Text = oku["cinsiyet"].ToString();
                textTelefon.Text = oku["telefon"].ToString();
                textAdres.Text = oku["adres"].ToString();
                textMail.Text = oku["mail"].ToString();
                textOkudugu.Text = oku["okuduguktp"].ToString();

            }
            baglanti.Close();
        }
        DataSet dtst = new DataSet(); //kayıtları geçici olarak tutacağımız yer
        private void textTcAra_TextChanged(object sender, EventArgs e)
        {
            dtst.Tables["uye"].Clear(); //arama kaydının tabloya her seferinde kaydolmaması için temizleme işlemi
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from uye where tc like '%"+textTcAra.Text+"%'", baglanti); //içinde arama ekranına yazılacak şeyi arayan kısım
            adptr.Fill(dtst,"uye");
            dataGridView1.DataSource = dtst.Tables["uye"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from uye where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc",dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Silindi");
            dtst.Tables["uye"].Clear();
            uyeListesi();
            foreach(Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        
        }
        private void uyeListesi() //Üyelerin Listelenme kısmı
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from uye",baglanti);
            adptr.Fill(dtst,"uye");
            dataGridView1.DataSource = dtst.Tables["uye"];
            baglanti.Close();
        }

        private void uyeListeform_Load(object sender, EventArgs e)
        {
            uyeListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,mail=@mail,okuduguktp=@okuduguktp where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc",textTc.Text);
            komut.Parameters.AddWithValue("@adsoyad",textAdsoyad.Text);
            komut.Parameters.AddWithValue("@yas",textYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet",comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon",textTelefon.Text);
            komut.Parameters.AddWithValue("@adres",textAdres.Text);
            komut.Parameters.AddWithValue("@mail",textMail.Text);
            komut.Parameters.AddWithValue("@okuduguktp",int.Parse(textOkudugu.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            dtst.Tables["uye"].Clear();
            uyeListesi();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }
    }
}
