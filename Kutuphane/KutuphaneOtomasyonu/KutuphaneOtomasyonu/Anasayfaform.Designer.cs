
namespace KutuphaneOtomasyonu
{
    partial class Anasayfaform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListe = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListe = new System.Windows.Forms.Button();
            this.btnKitapEkleme = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOduncIade = new System.Windows.Forms.Button();
            this.btnOduncListe = new System.Windows.Forms.Button();
            this.btnOduncAlma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeListe);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(67, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kayıt İşlemleri";
            // 
            // btnUyeListe
            // 
            this.btnUyeListe.Location = new System.Drawing.Point(23, 89);
            this.btnUyeListe.Name = "btnUyeListe";
            this.btnUyeListe.Size = new System.Drawing.Size(263, 23);
            this.btnUyeListe.TabIndex = 1;
            this.btnUyeListe.Text = "Üye Listesi";
            this.btnUyeListe.UseVisualStyleBackColor = true;
            this.btnUyeListe.Click += new System.EventHandler(this.btnUyeListe_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(23, 41);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(263, 23);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapListe);
            this.groupBox2.Controls.Add(this.btnKitapEkleme);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(447, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Kayıt İşlemleri";
            // 
            // btnKitapListe
            // 
            this.btnKitapListe.Location = new System.Drawing.Point(24, 89);
            this.btnKitapListe.Name = "btnKitapListe";
            this.btnKitapListe.Size = new System.Drawing.Size(263, 23);
            this.btnKitapListe.TabIndex = 1;
            this.btnKitapListe.Text = "Kitap Listesi";
            this.btnKitapListe.UseVisualStyleBackColor = true;
            this.btnKitapListe.Click += new System.EventHandler(this.btnKitapListe_Click);
            // 
            // btnKitapEkleme
            // 
            this.btnKitapEkleme.Location = new System.Drawing.Point(24, 41);
            this.btnKitapEkleme.Name = "btnKitapEkleme";
            this.btnKitapEkleme.Size = new System.Drawing.Size(263, 23);
            this.btnKitapEkleme.TabIndex = 0;
            this.btnKitapEkleme.Text = "Kitap Ekle";
            this.btnKitapEkleme.UseVisualStyleBackColor = true;
            this.btnKitapEkleme.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOduncIade);
            this.groupBox3.Controls.Add(this.btnOduncListe);
            this.groupBox3.Controls.Add(this.btnOduncAlma);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(261, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödünç Kitap İşlemleri";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnOduncIade
            // 
            this.btnOduncIade.Location = new System.Drawing.Point(23, 98);
            this.btnOduncIade.Name = "btnOduncIade";
            this.btnOduncIade.Size = new System.Drawing.Size(263, 23);
            this.btnOduncIade.TabIndex = 2;
            this.btnOduncIade.Text = "Ödünç Kitap İadesi";
            this.btnOduncIade.UseVisualStyleBackColor = true;
            // 
            // btnOduncListe
            // 
            this.btnOduncListe.Location = new System.Drawing.Point(23, 69);
            this.btnOduncListe.Name = "btnOduncListe";
            this.btnOduncListe.Size = new System.Drawing.Size(263, 23);
            this.btnOduncListe.TabIndex = 1;
            this.btnOduncListe.Text = "Ödünç Kitap Listesi";
            this.btnOduncListe.UseVisualStyleBackColor = true;
            this.btnOduncListe.Click += new System.EventHandler(this.btnOduncListe_Click);
            // 
            // btnOduncAlma
            // 
            this.btnOduncAlma.Location = new System.Drawing.Point(23, 40);
            this.btnOduncAlma.Name = "btnOduncAlma";
            this.btnOduncAlma.Size = new System.Drawing.Size(263, 23);
            this.btnOduncAlma.TabIndex = 0;
            this.btnOduncAlma.Text = "Ödünç Kitap Verme";
            this.btnOduncAlma.UseVisualStyleBackColor = true;
            this.btnOduncAlma.Click += new System.EventHandler(this.btnOduncAlma_Click);
            // 
            // Anasayfaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Anasayfaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Anasayfaform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUyeListe;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapListe;
        private System.Windows.Forms.Button btnKitapEkleme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOduncIade;
        private System.Windows.Forms.Button btnOduncListe;
        private System.Windows.Forms.Button btnOduncAlma;
    }
}

