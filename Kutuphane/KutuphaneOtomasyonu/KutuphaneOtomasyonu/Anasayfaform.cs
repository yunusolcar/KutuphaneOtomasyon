using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Anasayfaform : Form
    {
        public Anasayfaform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitapEkleform kitapEkle = new kitapEkleform();
            kitapEkle.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            uyeEklemeform uyeEkle = new uyeEklemeform();
            uyeEkle.ShowDialog();
        }

        private void btnUyeListe_Click(object sender, EventArgs e)
        {
            uyeListeform uyeListe = new uyeListeform();
            uyeListe.ShowDialog();
        }

        private void btnKitapListe_Click(object sender, EventArgs e)
        {
            kitapListeform kitapListe = new kitapListeform();
            kitapListe.ShowDialog();
        }

        private void btnOduncAlma_Click(object sender, EventArgs e)
        {
            oduncVermeform oduncVr = new oduncVermeform();
            oduncVr.ShowDialog();
        }

        private void btnOduncListe_Click(object sender, EventArgs e)
        {
            oduncListeform odunclste = new oduncListeform();
            odunclste.ShowDialog();
        }

        private void Anasayfaform_Load(object sender, EventArgs e)
        {

        }
    }
}
