using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using FACADELAYER;
using BUSINESSLOGICLAYER;
namespace KatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void OgrenciListesi()
        {
            List<ENTITYOGRENCI> OgrList = BLLOGRENCI.LISTELE();
            dataGridView1.DataSource = OgrList;
            this.Text = "Öğrenci Listesi";
        }

        void KulupListesi()
        {
            List<ENTITYKULUP> KulupList = BLLKULUP.LISTELE();
            CmbKulup.DisplayMember = "KULUPAD";
            CmbKulup.ValueMember = "KULUPID";
            CmbKulup.DataSource = KulupList;
            dataGridView1.DataSource = KulupList;
            this.Text = "Kulüp Listesi";
        }
        void NotListesi()
        {
            List<ENTITYNOTLAR> EntNot = BLLNOTLAR.LISTELE();
            dataGridView1.DataSource = EntNot;
            this.Text = "Not Listesi";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //OgrenciListesi();
            //KulupListesi();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.FOTOGRAF = TxtFotoğraf.Text;
            ent.KULUPID = Convert.ToInt32(CmbKulup.SelectedValue);
            BLLOGRENCI.EKLE(ent);
            MessageBox.Show("Öğrenci Kaydı Yapıldı");
            OgrenciListesi();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.FOTOGRAF = TxtFotoğraf.Text;
            ent.KULUPID = Convert.ToInt32(CmbKulup.SelectedValue);
            ent.ID = Convert.ToInt32(txtID.Text);
            BLLOGRENCI.GUNCELLE(ent);
            MessageBox.Show("Öğrenci Bilgileri Güncellendi");
            OgrenciListesi();
        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {
            NotListesi();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            OgrenciListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text=="Öğrenci Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtAd.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtSoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtFotoğraf.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            }
            if (this.Text=="Not Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                TxtNotlarID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtAd.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                TxtSoyad.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                TxtSinav1.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtSinav2.Text=dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtSinav3.Text=dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                TxtProje.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                TxtOrtalama.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                TxtDurum.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                

            }
        }

        private void BtnNotGuncelle_Click(object sender, EventArgs e)
        {
            ENTITYNOTLAR ent = new ENTITYNOTLAR();
            ent.OGRENCIID = Convert.ToInt32(TxtNotlarID.Text);
            ent.SINAV1 = Convert.ToInt32(TxtSinav1.Text);
            ent.SINAV2 = Convert.ToInt32(TxtSinav2.Text);
            ent.SINAV3 = Convert.ToInt32(TxtSinav3.Text);
            ent.PROJE = Convert.ToInt32(TxtProje.Text);
            ent.ORTALAMA = Convert.ToInt32(TxtOrtalama.Text);
            ent.DURUM = TxtSinav1.Text;
            BLLNOTLAR.GUNCELLE(ent);
            MessageBox.Show("Notlar Güncellendi!");
            NotListesi();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, proje;
            double ortalama;
            string durum;
            s1 = Convert.ToInt32(TxtSinav1.Text);
            s2 = Convert.ToInt32(TxtSinav2.Text);
            s3= Convert.ToInt32(TxtSinav3.Text);
            proje = Convert.ToInt32(TxtProje.Text);
            ortalama = (s1+s2+s3+proje)/4;
            TxtOrtalama.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            TxtDurum.Text = durum;
        }

        private void BtnKulupListele_Click(object sender, EventArgs e)
        {
            KulupListesi();
        }

        private void BtnKulupKaydet_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPAD = TxtKulupAd.Text;
            BLLKULUP.EKLE(ent);
            KulupListesi();
        }

        private void BtnKulupSil_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPID = Convert.ToInt32(TxtKulupID.Text);
            BLLKULUP.SIL(ent.KULUPID);
            KulupListesi();
        }

        private void BtnKulupGuncelle_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPAD = TxtKulupAd.Text;
            ent.KULUPID = Convert.ToInt32(TxtKulupID.Text);
            BLLKULUP.GUNCELLE(ent);
            KulupListesi();
        }
    }
}
