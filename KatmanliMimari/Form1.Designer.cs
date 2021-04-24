
namespace KatmanliMimari
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.CmbKulup = new System.Windows.Forms.ComboBox();
            this.TxtFotoğraf = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtProje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.BtnNotGuncelle = new System.Windows.Forms.Button();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.TxtNotlarID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKulupListele = new System.Windows.Forms.Button();
            this.BtnKulupGuncelle = new System.Windows.Forms.Button();
            this.BtnKulupSil = new System.Windows.Forms.Button();
            this.BtnKulupKaydet = new System.Windows.Forms.Button();
            this.TxtKulupAd = new System.Windows.Forms.TextBox();
            this.TxtKulupID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnListele);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.CmbKulup);
            this.groupBox1.Controls.Add(this.TxtFotoğraf);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(237, 254);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(100, 35);
            this.BtnListele.TabIndex = 13;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(131, 254);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(100, 35);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(237, 213);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(100, 35);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(131, 213);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(100, 35);
            this.BtnKaydet.TabIndex = 10;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // CmbKulup
            // 
            this.CmbKulup.FormattingEnabled = true;
            this.CmbKulup.Location = new System.Drawing.Point(131, 175);
            this.CmbKulup.Name = "CmbKulup";
            this.CmbKulup.Size = new System.Drawing.Size(206, 32);
            this.CmbKulup.TabIndex = 9;
            // 
            // TxtFotoğraf
            // 
            this.TxtFotoğraf.Location = new System.Drawing.Point(131, 141);
            this.TxtFotoğraf.Name = "TxtFotoğraf";
            this.TxtFotoğraf.Size = new System.Drawing.Size(206, 29);
            this.TxtFotoğraf.TabIndex = 8;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(131, 106);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(206, 29);
            this.TxtSoyad.TabIndex = 7;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(131, 68);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(206, 29);
            this.TxtAd.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(206, 29);
            this.txtID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "KULUP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnHesapla);
            this.groupBox2.Controls.Add(this.TxtDurum);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtOrtalama);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtProje);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtSinav3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtSinav2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnNotListesi);
            this.groupBox2.Controls.Add(this.BtnNotGuncelle);
            this.groupBox2.Controls.Add(this.TxtSinav1);
            this.groupBox2.Controls.Add(this.TxtNotlarID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(370, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 300);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOTLAR";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(298, 129);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(100, 29);
            this.TxtDurum.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "DURUM:";
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Location = new System.Drawing.Point(298, 95);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(100, 29);
            this.TxtOrtalama.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "ORTALA:";
            // 
            // TxtProje
            // 
            this.TxtProje.Location = new System.Drawing.Point(298, 55);
            this.TxtProje.Name = "TxtProje";
            this.TxtProje.Size = new System.Drawing.Size(100, 29);
            this.TxtProje.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "PROJE:";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(96, 127);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(100, 29);
            this.TxtSinav3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "SINAV3:";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(96, 93);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(100, 29);
            this.TxtSinav2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "SINAV2:";
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(167, 164);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(100, 35);
            this.BtnNotListesi.TabIndex = 13;
            this.BtnNotListesi.Text = "Listele";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // BtnNotGuncelle
            // 
            this.BtnNotGuncelle.Location = new System.Drawing.Point(24, 167);
            this.BtnNotGuncelle.Name = "BtnNotGuncelle";
            this.BtnNotGuncelle.Size = new System.Drawing.Size(100, 35);
            this.BtnNotGuncelle.TabIndex = 12;
            this.BtnNotGuncelle.Text = "Güncelle";
            this.BtnNotGuncelle.UseVisualStyleBackColor = true;
            this.BtnNotGuncelle.Click += new System.EventHandler(this.BtnNotGuncelle_Click);
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(96, 58);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(100, 29);
            this.TxtSinav1.TabIndex = 6;
            // 
            // TxtNotlarID
            // 
            this.TxtNotlarID.Location = new System.Drawing.Point(96, 26);
            this.TxtNotlarID.Name = "TxtNotlarID";
            this.TxtNotlarID.Size = new System.Drawing.Size(100, 29);
            this.TxtNotlarID.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "SINAV1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKulupListele);
            this.groupBox3.Controls.Add(this.BtnKulupGuncelle);
            this.groupBox3.Controls.Add(this.BtnKulupSil);
            this.groupBox3.Controls.Add(this.BtnKulupKaydet);
            this.groupBox3.Controls.Add(this.TxtKulupAd);
            this.groupBox3.Controls.Add(this.TxtKulupID);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(799, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 300);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KULUP";
            // 
            // BtnKulupListele
            // 
            this.BtnKulupListele.Location = new System.Drawing.Point(183, 164);
            this.BtnKulupListele.Name = "BtnKulupListele";
            this.BtnKulupListele.Size = new System.Drawing.Size(100, 35);
            this.BtnKulupListele.TabIndex = 17;
            this.BtnKulupListele.Text = "Listele";
            this.BtnKulupListele.UseVisualStyleBackColor = true;
            this.BtnKulupListele.Click += new System.EventHandler(this.BtnKulupListele_Click);
            // 
            // BtnKulupGuncelle
            // 
            this.BtnKulupGuncelle.Location = new System.Drawing.Point(77, 164);
            this.BtnKulupGuncelle.Name = "BtnKulupGuncelle";
            this.BtnKulupGuncelle.Size = new System.Drawing.Size(100, 35);
            this.BtnKulupGuncelle.TabIndex = 16;
            this.BtnKulupGuncelle.Text = "Güncelle";
            this.BtnKulupGuncelle.UseVisualStyleBackColor = true;
            this.BtnKulupGuncelle.Click += new System.EventHandler(this.BtnKulupGuncelle_Click);
            // 
            // BtnKulupSil
            // 
            this.BtnKulupSil.Location = new System.Drawing.Point(183, 123);
            this.BtnKulupSil.Name = "BtnKulupSil";
            this.BtnKulupSil.Size = new System.Drawing.Size(100, 35);
            this.BtnKulupSil.TabIndex = 15;
            this.BtnKulupSil.Text = "Sil";
            this.BtnKulupSil.UseVisualStyleBackColor = true;
            this.BtnKulupSil.Click += new System.EventHandler(this.BtnKulupSil_Click);
            // 
            // BtnKulupKaydet
            // 
            this.BtnKulupKaydet.Location = new System.Drawing.Point(77, 123);
            this.BtnKulupKaydet.Name = "BtnKulupKaydet";
            this.BtnKulupKaydet.Size = new System.Drawing.Size(100, 35);
            this.BtnKulupKaydet.TabIndex = 14;
            this.BtnKulupKaydet.Text = "Kaydet";
            this.BtnKulupKaydet.UseVisualStyleBackColor = true;
            this.BtnKulupKaydet.Click += new System.EventHandler(this.BtnKulupKaydet_Click);
            // 
            // TxtKulupAd
            // 
            this.TxtKulupAd.Location = new System.Drawing.Point(121, 58);
            this.TxtKulupAd.Name = "TxtKulupAd";
            this.TxtKulupAd.Size = new System.Drawing.Size(162, 29);
            this.TxtKulupAd.TabIndex = 6;
            // 
            // TxtKulupID
            // 
            this.TxtKulupID.Location = new System.Drawing.Point(121, 26);
            this.TxtKulupID.Name = "TxtKulupID";
            this.TxtKulupID.Size = new System.Drawing.Size(162, 29);
            this.TxtKulupID.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "KULUP AD:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(83, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1113, 239);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1107, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(298, 167);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(100, 35);
            this.BtnHesapla.TabIndex = 24;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1137, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ComboBox CmbKulup;
        private System.Windows.Forms.TextBox TxtFotoğraf;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtProje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button BtnNotGuncelle;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.TextBox TxtNotlarID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtKulupAd;
        private System.Windows.Forms.TextBox TxtKulupID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnKulupListele;
        private System.Windows.Forms.Button BtnKulupGuncelle;
        private System.Windows.Forms.Button BtnKulupSil;
        private System.Windows.Forms.Button BtnKulupKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnHesapla;
    }
}

