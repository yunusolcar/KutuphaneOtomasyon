
namespace KutuphaneOtomasyonu
{
    partial class kitapEkleform
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
            this.textBarkod = new System.Windows.Forms.TextBox();
            this.textKitapAdi = new System.Windows.Forms.TextBox();
            this.textKitapYazari = new System.Windows.Forms.TextBox();
            this.textYayınevi = new System.Windows.Forms.TextBox();
            this.textSayfa = new System.Windows.Forms.TextBox();
            this.textStok = new System.Windows.Forms.TextBox();
            this.textRaf = new System.Windows.Forms.TextBox();
            this.textAcıklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKtpIptal = new System.Windows.Forms.Button();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBarkod
            // 
            this.textBarkod.Location = new System.Drawing.Point(95, 49);
            this.textBarkod.Name = "textBarkod";
            this.textBarkod.Size = new System.Drawing.Size(178, 20);
            this.textBarkod.TabIndex = 0;
            this.textBarkod.TextChanged += new System.EventHandler(this.textBarkod_TextChanged);
            // 
            // textKitapAdi
            // 
            this.textKitapAdi.Location = new System.Drawing.Point(95, 85);
            this.textKitapAdi.Name = "textKitapAdi";
            this.textKitapAdi.Size = new System.Drawing.Size(178, 20);
            this.textKitapAdi.TabIndex = 1;
            // 
            // textKitapYazari
            // 
            this.textKitapYazari.Location = new System.Drawing.Point(95, 120);
            this.textKitapYazari.Name = "textKitapYazari";
            this.textKitapYazari.Size = new System.Drawing.Size(178, 20);
            this.textKitapYazari.TabIndex = 2;
            // 
            // textYayınevi
            // 
            this.textYayınevi.Location = new System.Drawing.Point(95, 156);
            this.textYayınevi.Name = "textYayınevi";
            this.textYayınevi.Size = new System.Drawing.Size(178, 20);
            this.textYayınevi.TabIndex = 3;
            // 
            // textSayfa
            // 
            this.textSayfa.Location = new System.Drawing.Point(95, 192);
            this.textSayfa.Name = "textSayfa";
            this.textSayfa.Size = new System.Drawing.Size(178, 20);
            this.textSayfa.TabIndex = 4;
            // 
            // textStok
            // 
            this.textStok.Location = new System.Drawing.Point(95, 268);
            this.textStok.Name = "textStok";
            this.textStok.Size = new System.Drawing.Size(178, 20);
            this.textStok.TabIndex = 6;
            // 
            // textRaf
            // 
            this.textRaf.Location = new System.Drawing.Point(95, 305);
            this.textRaf.Name = "textRaf";
            this.textRaf.Size = new System.Drawing.Size(178, 20);
            this.textRaf.TabIndex = 7;
            // 
            // textAcıklama
            // 
            this.textAcıklama.Location = new System.Drawing.Point(95, 342);
            this.textAcıklama.Multiline = true;
            this.textAcıklama.Name = "textAcıklama";
            this.textAcıklama.Size = new System.Drawing.Size(178, 37);
            this.textAcıklama.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kitap Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kitap Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kitap Yazarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yayınevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kitap Sayfası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kitap Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kitap Stoğu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kitap Raf. No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Açıklama";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(95, 385);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 29);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kayıt Et";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKtpEkle_Click);
            // 
            // btnKtpIptal
            // 
            this.btnKtpIptal.Location = new System.Drawing.Point(198, 385);
            this.btnKtpIptal.Name = "btnKtpIptal";
            this.btnKtpIptal.Size = new System.Drawing.Size(75, 29);
            this.btnKtpIptal.TabIndex = 20;
            this.btnKtpIptal.Text = "İptal";
            this.btnKtpIptal.UseVisualStyleBackColor = true;
            this.btnKtpIptal.Click += new System.EventHandler(this.btnKtpIptal_Click);
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
            "ÇOCUK KİTAPLARI"});
            this.comboTur.Location = new System.Drawing.Point(95, 233);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(178, 21);
            this.comboTur.TabIndex = 21;
            // 
            // kitapEkleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(333, 458);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.btnKtpIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAcıklama);
            this.Controls.Add(this.textRaf);
            this.Controls.Add(this.textStok);
            this.Controls.Add(this.textSayfa);
            this.Controls.Add(this.textYayınevi);
            this.Controls.Add(this.textKitapYazari);
            this.Controls.Add(this.textKitapAdi);
            this.Controls.Add(this.textBarkod);
            this.Name = "kitapEkleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekleme";
            this.Load += new System.EventHandler(this.kitapEkleform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBarkod;
        private System.Windows.Forms.TextBox textKitapAdi;
        private System.Windows.Forms.TextBox textKitapYazari;
        private System.Windows.Forms.TextBox textYayınevi;
        private System.Windows.Forms.TextBox textSayfa;
        private System.Windows.Forms.TextBox textStok;
        private System.Windows.Forms.TextBox textRaf;
        private System.Windows.Forms.TextBox textAcıklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKtpIptal;
        private System.Windows.Forms.ComboBox comboTur;
    }
}