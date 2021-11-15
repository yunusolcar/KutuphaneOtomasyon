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
    public partial class oduncListeform : Form
    {
        public oduncListeform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7K9ONPQ\\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");
        DataSet dtst = new DataSet();
        private void oduncListeform_Load(object sender, EventArgs e)
        {

            oduncListele();
            comboBox1.SelectedIndex = 0;
        
        
        }
            private void oduncListele() {
                baglanti.Open();
                SqlDataAdapter adptr = new SqlDataAdapter("select * from oduncKitap", baglanti);
                adptr.Fill(dtst, "oduncKitap");
                dataGridView1.DataSource = dtst.Tables["oduncKitap"];
                baglanti.Close();
            }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            dtst.Tables["oduncKitap"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                oduncListele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adptr = new SqlDataAdapter("select * from oduncKitap where '"+DateTime.Now.ToShortDateString()+"'>iadeTarih",baglanti);
                adptr.Fill(dtst, "oduncKitap");
                dataGridView1.DataSource = dtst.Tables["oduncKitap"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adptr = new SqlDataAdapter("select * from oduncKitap where '" + DateTime.Now.ToShortDateString() + "'<=iadeTarih", baglanti);
                adptr.Fill(dtst, "oduncKitap");
                dataGridView1.DataSource = dtst.Tables["oduncKitap"];
                baglanti.Close();
            }
        }
    }
}
