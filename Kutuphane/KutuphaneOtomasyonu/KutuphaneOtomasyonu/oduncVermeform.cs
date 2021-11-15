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
    public partial class oduncVermeform : Form
    {
        public oduncVermeform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7K9ONPQ\\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");
        DataSet dtst = new DataSet();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetListesi()
        {
            baglanti.Open();
            SqlDataAdapter adptr =new SqlDataAdapter("select * from sepet", baglanti);
            adptr.Fill(dtst, "sepet");
            dataGridView1.DataSource = dtst.Tables["sepet"];
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); 
            SqlCommand komut = new SqlCommand("insert into sepet(barkodNo,kitapAdi,yazar,yayinevi,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi) values(@barkodNo,@kitapAdi,@yazar,@yayinevi,@sayfaSayisi,@kitapSayisi,@teslimTarihi,@iadeTarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodNo",textBarkodt.Text);
            komut.Parameters.AddWithValue("@kitapAdi", textKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", textYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", textYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfaSayisi", textSayfa.Text);
            komut.Parameters.AddWithValue("@kitapSayisi",int.Parse(textKitapSayi.Text));
            komut.Parameters.AddWithValue("@teslimTarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadeTarihi",dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepete Eklendi");
            dtst.Tables["sepet"].Clear();
            sepetListesi();
            lblKitapSayisi.Text = "";
            kitapsayi();
            foreach(Control item in groupBoxKitap.Controls)
            {
                if(item is TextBox)
                {
                    if (item!= textKitapSayi)
                    {
                        item.Text = "";
                    }
                }
            }
        }
        private void kitapsayi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapSayisi) from sepet", baglanti);
            lblKitapSayisi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void oduncVermefotm_Load(object sender, EventArgs e)
        {
            sepetListesi();
            kitapsayi();
        
        }

        private void textTcArama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uye where tc like'"+textTcArama.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textAdSoyad.Text = read["adsoyad"].ToString();
                textYas.Text = read["yas"].ToString();
                textTlf.Text = read["telefon"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapSayi) from oduncKitap where tc like'"+textTcArama.Text+"'",baglanti);
            lblKayitliKitap.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (textTcArama.Text == "")
            {
                foreach(Control item in groupBoxUye.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                            
                    }
                    
                }
                 lblKayitliKitap.Text = "";
            }
        }

        private void textBarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitap where barkod like '"+textBarkodt.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textKitapAdi.Text = read["kitapAdi"].ToString();
                textYazar.Text = read["yazar"].ToString();
                textYayinevi.Text = read["yayinevi"].ToString();
                textSayfa.Text = read["sayfasayisi"].ToString();
                
            }
            baglanti.Close();
            if (textBarkodt.Text == "")
            {
                foreach (Control item in groupBoxKitap.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item!=textKitapSayi)
                        {
                            item.Text = "";
                        }
                        
                    }
                    lblKitapSayisi.Text= "";
                }
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodNo='"+dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi");
            dtst.Tables["sepet"].Clear();
            sepetListesi();
            lblKitapSayisi.Text = "";
            kitapsayi(); 
        
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayisi.Text!="")
            {

                if (lblKayitliKitap.Text=="" && int.Parse(lblKitapSayisi.Text)<= 5 || lblKayitliKitap.Text!="" && int.Parse(lblKayitliKitap.Text) + int.Parse(lblKitapSayisi.Text)<= 5)
                {
                    if (textTcArama.Text!="" && textAdSoyad.Text!= "" && textYas.Text!= "" && textTlf.Text!= "")
                    {

                           for(int a = 0; a < dataGridView1.Rows.Count-1; a++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into oduncKitap(tc,adSoyad,yas,telefon,barkodNo,kitapAdi,yazar,yayinevi,sayfaSayi,kitapSayi,teslimTarih,iadeTarih)" +
                                "values(@tc,@adSoyad,@yas,@telefon,@barkodNo,@kitapAdi,@yazar,@yayinevi,@sayfaSayi,@kitapSayi,@teslimTarih,@iadeTarih)", baglanti);
                            komut.Parameters.AddWithValue("@tc", textTcArama.Text);
                            komut.Parameters.AddWithValue("@adSoyad", textAdSoyad.Text);
                            komut.Parameters.AddWithValue("@yas", textYas.Text);
                            komut.Parameters.AddWithValue("@telefon", textTlf.Text);
                            komut.Parameters.AddWithValue("@barkodNo",dataGridView1.Rows[a].Cells["barkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapAdi", dataGridView1.Rows[a].Cells["kitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("@yazar", dataGridView1.Rows[a].Cells["yazar"].Value.ToString());
                            komut.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[a].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@sayfaSayi", dataGridView1.Rows[a].Cells["sayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapSayi", dataGridView1.Rows[a].Cells["kitapSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@teslimTarih", dataGridView1.Rows[a].Cells["teslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadeTarih", dataGridView1.Rows[a].Cells["iadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update uye set okuduguktp=okuduguktp+'"+int.Parse(dataGridView1.Rows[a].Cells["kitapSayi"].Value.ToString())+"' where tc='"+textTcArama.Text+"' ",baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update kitap set stok=stok-'" + int.Parse(dataGridView1.Rows[a].Cells["kitapSayi"].Value.ToString())+"' where barkodNo='"+dataGridView1.Rows[a].Cells["barkodNo"].Value.ToString()+ "' ", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();


                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Ödünç İşlemi Başarılı");
                        dtst.Tables["sepet"].Clear();
                        sepetListesi();
                        textTcArama.Text = "";
                        lblKitapSayisi.Text = "";
                        kitapsayi();
                        lblKayitliKitap.Text = "";

                        //komut satırları
                    }
                    else
                    {
                        MessageBox.Show("Üye ismi seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("3'ten fazla ödünç kitap alınamaz!");
                }


            }
            else
            {
                MessageBox.Show("Sepete kitap ekleyiniz!");
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
