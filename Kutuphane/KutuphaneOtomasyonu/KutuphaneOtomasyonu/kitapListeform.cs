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
    public partial class kitapListeform : Form
    {
        public kitapListeform()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7K9ONPQ\\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");
        DataSet dtst = new DataSet();
        private void kitapListesi() //Kitapların Listelenme kısmı
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from kitap",baglanti);
            adptr.Fill(dtst, "kitap");
            dataGridView1.DataSource = dtst.Tables["kitap"];
            baglanti.Close();
        }
        private void kitapListeform_Load(object sender, EventArgs e)
        {
            kitapListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kitap where barkod=@barkod", baglanti);
            komut.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Sildiniz");
            dtst.Tables["kitap"].Clear();
            kitapListesi();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set kitapAdi=@kitapAdi,yazar=@yazar,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu,stok=@stok,rafno=@rafno,aciklama=@aciklama where barkod=@barkod",baglanti);
            komut.Parameters.AddWithValue("@barkod",textBarkd.Text);
            komut.Parameters.AddWithValue("@kitapAdi",textKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar",textKitapYazari.Text);
            komut.Parameters.AddWithValue("@yayinevi",textYayınevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi",textSayfa.Text);
            komut.Parameters.AddWithValue("@turu",comboTur.Text);
            komut.Parameters.AddWithValue("@stok",textStok.Text);
            komut.Parameters.AddWithValue("@rafno",textRaf.Text);
            komut.Parameters.AddWithValue("@aciklama",textAciklama.Text);
          
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");
            dtst.Tables["kitap"].Clear();
            kitapListesi();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void textBarkodArama_TextChanged(object sender, EventArgs e)
        {
            dtst.Tables["kitap"].Clear(); //arama kaydının tabloya her seferinde kaydolmaması için temizleme işlemi
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from kitap where barkod like '%" + textBarkodArama.Text + "%'", baglanti); //içinde arama ekranına yazılacak şeyi arayan kısım
            adptr.Fill(dtst, "kitap");
            dataGridView1.DataSource = dtst.Tables["kitap"];
            baglanti.Close();
        }

        private void btnKtpIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
            private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                textBarkd.Text = dataGridView1.CurrentRow.Cells["kitap"].Value.ToString();
            }

        private void textBarkd_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitap where barkod like '" + textBarkd.Text+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textKitapAdi.Text = oku["kitapAdi"].ToString();
                textKitapYazari.Text = oku["yazar"].ToString();
                textYayınevi.Text = oku["yayinevi"].ToString();
                textSayfa.Text = oku["sayfasayisi"].ToString();
                comboTur.Text = oku["turu"].ToString();
                textStok.Text = oku["stok"].ToString();
                textRaf.Text = oku["rafno"].ToString();
                textAciklama.Text = oku["aciklama"].ToString();


            }
            baglanti.Close();
        }
    }
    }
    
