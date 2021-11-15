
namespace KutuphaneOtomasyonu
{
    partial class kitapListeform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.btnKtpIptal = new System.Windows.Forms.Button();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.textRaf = new System.Windows.Forms.TextBox();
            this.textStok = new System.Windows.Forms.TextBox();
            this.textSayfa = new System.Windows.Forms.TextBox();
            this.textYayınevi = new System.Windows.Forms.TextBox();
            this.textKitapYazari = new System.Windows.Forms.TextBox();
            this.textKitapAdi = new System.Windows.Forms.TextBox();
            this.textBarkd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBarkodArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTur
            // 
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "ROMAN",
            "HİKAYE",
            "ANSİKLOPEDİ",
            "ANI KİTAPLARI",
            "GEZİ KİTAPLARI",
            "ŞİİR",
            "DİNİ KİTAPLAR",
            "BİLGİ KİTAPLARI",
            "ÇOCUK KİTAPLARI",
            "TARİH",
            "EDEBİYAT",
            "FİZİK",
            "KİMYA",
            "BİYOLOJİ",
            "SPOR"});
            this.comboTur.Location = new System.Drawing.Point(93, 234);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(178, 21);
            this.comboTur.TabIndex = 41;
            // 
            // btnKtpIptal
            // 
            this.btnKtpIptal.Location = new System.Drawing.Point(196, 386);
            this.btnKtpIptal.Name = "btnKtpIptal";
            this.btnKtpIptal.Size = new System.Drawing.Size(75, 29);
            this.btnKtpIptal.TabIndex = 40;
            this.btnKtpIptal.Text = "İptal";
            this.btnKtpIptal.UseVisualStyleBackColor = true;
            this.btnKtpIptal.Click += new System.EventHandler(this.btnKtpIptal_Click);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(93, 386);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(79, 29);
            this.btnGuncelleme.TabIndex = 39;
            this.btnGuncelleme.Text = "Güncelle";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Kitap Raf. No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Kitap Stoğu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Kitap Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kitap Sayfası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kitap Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kitap Barkod";
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(93, 343);
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(178, 20);
            this.textAciklama.TabIndex = 29;
            // 
            // textRaf
            // 
            this.textRaf.Location = new System.Drawing.Point(93, 306);
            this.textRaf.Name = "textRaf";
            this.textRaf.Size = new System.Drawing.Size(178, 20);
            this.textRaf.TabIndex = 28;
            // 
            // textStok
            // 
            this.textStok.Location = new System.Drawing.Point(93, 269);
            this.textStok.Name = "textStok";
            this.textStok.Size = new System.Drawing.Size(178, 20);
            this.textStok.TabIndex = 27;
            // 
            // textSayfa
            // 
            this.textSayfa.Location = new System.Drawing.Point(93, 193);
            this.textSayfa.Name = "textSayfa";
            this.textSayfa.Size = new System.Drawing.Size(178, 20);
            this.textSayfa.TabIndex = 26;
            // 
            // textYayınevi
            // 
            this.textYayınevi.Location = new System.Drawing.Point(93, 157);
            this.textYayınevi.Name = "textYayınevi";
            this.textYayınevi.Size = new System.Drawing.Size(178, 20);
            this.textYayınevi.TabIndex = 25;
            // 
            // textKitapYazari
            // 
            this.textKitapYazari.Location = new System.Drawing.Point(93, 121);
            this.textKitapYazari.Name = "textKitapYazari";
            this.textKitapYazari.Size = new System.Drawing.Size(178, 20);
            this.textKitapYazari.TabIndex = 24;
            // 
            // textKitapAdi
            // 
            this.textKitapAdi.Location = new System.Drawing.Point(93, 86);
            this.textKitapAdi.Name = "textKitapAdi";
            this.textKitapAdi.Size = new System.Drawing.Size(178, 20);
            this.textKitapAdi.TabIndex = 23;
            // 
            // textBarkd
            // 
            this.textBarkd.Location = new System.Drawing.Point(93, 50);
            this.textBarkd.Name = "textBarkd";
            this.textBarkd.Size = new System.Drawing.Size(178, 20);
            this.textBarkd.TabIndex = 46;
            this.textBarkd.TextChanged += new System.EventHandler(this.textBarkd_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 330);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(755, 389);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Kitap Barkod Arama";
            // 
            // textBarkodArama
            // 
            this.textBarkodArama.Location = new System.Drawing.Point(533, 21);
            this.textBarkodArama.Name = "textBarkodArama";
            this.textBarkodArama.Size = new System.Drawing.Size(178, 20);
            this.textBarkodArama.TabIndex = 44;
            this.textBarkodArama.TextChanged += new System.EventHandler(this.textBarkodArama_TextChanged);
            // 
            // kitapListeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1269, 455);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBarkodArama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.btnKtpIptal);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAciklama);
            this.Controls.Add(this.textRaf);
            this.Controls.Add(this.textStok);
            this.Controls.Add(this.textSayfa);
            this.Controls.Add(this.textYayınevi);
            this.Controls.Add(this.textKitapYazari);
            this.Controls.Add(this.textKitapAdi);
            this.Controls.Add(this.textBarkd);
            this.Name = "kitapListeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.kitapListeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.Button btnKtpIptal;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.TextBox textRaf;
        private System.Windows.Forms.TextBox textStok;
        private System.Windows.Forms.TextBox textSayfa;
        private System.Windows.Forms.TextBox textYayınevi;
        private System.Windows.Forms.TextBox textKitapYazari;
        private System.Windows.Forms.TextBox textKitapAdi;
        private System.Windows.Forms.TextBox textBarkd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBarkodArama;
    }
}