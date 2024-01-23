using DernekTakipOtomasyon.BusinessLayer.Concrete;
using DernekTakipOtomasyon.DataAccessLayer;
using DernekTakipOtomasyon.DataAccessLayer.Concrete;
using DernekTakipOtomasyon.DataAccessLayer.Context;
using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DernekTakipOtomasyon.PresentationLayer
{
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }

        // Uye tablosu için oluşturulan mimariye erişebilmek adına nesne üretildi.
        UyeManager uyeManager = new UyeManager(new UyeRepository());

        // Veri tabanından direkt olarak erişmemiz gerektiği durumlarda nesne üretildi.
        DernekTakipEntities db = new DernekTakipEntities();  

        // Ekleme işlemi için Uye tablosundan nesne üretildi
        Uye uye = new Uye();  

        void Temizle()  // Güncelleme ve silme işlemi sonrası ilgili alanlarda bulunan bilgilerin temizlenmesi için
        {
            mskdTC.Text = " ";
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            dateTimePicker1.Value= DateTime.Now;
            cmbSehir.Text = " ";
            cmbKanGrup.Text = " ";
            txtEmail.Text = " ";
            radioAktif.Checked = false;
            radioPasif.Checked = false;
        }

        void Listele()  // Veri ekleme, silme, güncelleme işlemi sonrasında datagridview'daki bilgiler tekrardan listelensin
        {
            dataGridUye.DataSource = uyeManager.GetList();
        }
        private void UyeIslemleri_Load(object sender, EventArgs e)
        {
            Listele();

            illerManager illermanager = new illerManager(new illerRepository());

            var sehirler = illermanager.GetSehir();

            // Sayfa yüklendiğinde combobox'ta şehirler listelensin
            for (int i = 0; i < sehirler.Count; i++)
            {
                cmbSehir.Items.Add(sehirler[i]);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            uye.TC = mskdTC.Text;
            uye.Ad = txtAd.Text;
            uye.Soyad = txtSoyad.Text;
            uye.DogumTarihi = dateTimePicker1.Value.Date;
            uye.Sehir = cmbSehir.Text;
            uye.KanGrubu = cmbKanGrup.Text;
            uye.EMail = txtEmail.Text;
            if (radioAktif.Checked)
            {
                uye.Durum = true;
            }
            else if(radioPasif.Checked)
            {
                uye.Durum = false;
            }

            var kisiTCVar = db.Uye.Where(x => x.TC == mskdTC.Text).FirstOrDefault();  // Girilen TC veri tabanında varsa o veriyi çek
            
            var kisiMailVar = db.Uye.Where(x => x.EMail== txtEmail.Text).FirstOrDefault();

            // kisiTCVar alanı null dönmüyorsa yani girilen TC veri tabanında kayıtlıysa çalışacak olan kod bloğu
            if (kisiTCVar != null) 
                MessageBox.Show("Girilen TC kimlik numaralı üye zaten eklenmiş!", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            // kisiMailVar alanı null dönmüyorsa yani girilen E-Mail veri tabanında kayıtlıysa çalışacak olan kod bloğu
            else if (kisiMailVar != null)  
                MessageBox.Show("Girilen E-Mail'e ait üye zaten eklenmiş!", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            else  // Tüm işlemler doğru bir şekilde ilerlediyse ekleme işlemi yapılacak
            {
                uyeManager.TAdd(uye);
                Listele();
                MessageBox.Show("Başarıyla eklendi.", "Üye Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }               

            Temizle();  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçilen kişinin bilgileri ilgili alanlara aktarıldığında TC alanında yer alan kişinin ID bilgisini veri tabanından çeker
            var kisiID = db.Uye.Where(x => x.TC.Equals(mskdTC.Text)).Select(y => y.ID).FirstOrDefault();

            var silinecekID = uyeManager.TGetById(kisiID); // Silinecek kişinin ID'sini Uye tablosunda arayarak o kişinin tüm bilgilerini çek
            uyeManager.TDelete(silinecekID);

            Listele();

            MessageBox.Show("Başarıyla silindi.","Üye Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridUye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridUye.SelectedCells[0].RowIndex;
            mskdTC.Text = dataGridUye.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridUye.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridUye.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridUye.Rows[secilen].Cells[4].Value);
            cmbSehir.Text = dataGridUye.Rows[secilen].Cells[5].Value.ToString();
            cmbKanGrup.Text = dataGridUye.Rows[secilen].Cells[6].Value.ToString();
            txtEmail.Text = dataGridUye.Rows[secilen].Cells[7].Value.ToString();
            if (dataGridUye.Rows[secilen].Cells[8].Value.ToString() == "True") // seçilen kaydın Durum bilgisi True ise
            {
                radioAktif.Checked = true;  // Aktif olan radiobutonu seçili hale getir.
            }
            else if(dataGridUye.Rows[secilen].Cells[8].Value.ToString() == "False") // seçilen kaydın Durum bilgisi False ise
            {
                radioPasif.Checked = true; // Pasif olan radiobutonu seçili hale getir.
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçilen kişinin bilgileri ilgili alanlara aktarıldığında TC alanında yer alan kişinin ID bilgisini veri tabanından çeker.
            var kisiID = db.Uye.Where(x => x.TC.Equals(mskdTC.Text)).Select(y => y.ID).FirstOrDefault();

            // Güncelleme yapılacak kişinin ID'sini Uye tablosunda arayarak o kişinin tüm bilgilerini çek.
            var guncelleme = uyeManager.TGetById(kisiID);

            guncelleme.TC = mskdTC.Text;
            guncelleme.Ad = txtAd.Text;
            guncelleme.Soyad = txtSoyad.Text;
            guncelleme.DogumTarihi = dateTimePicker1.Value.Date;
            guncelleme.Sehir = cmbSehir.Text;
            guncelleme.KanGrubu = cmbKanGrup.Text;
            guncelleme.EMail = txtEmail.Text;
            if (radioAktif.Checked)
                guncelleme.Durum = true;
            else if (radioPasif.Checked)
                guncelleme.Durum = false;

            uyeManager.TUpdate(guncelleme);

            Listele();
            Temizle();
            MessageBox.Show("Başarıyla güncellendi.", "Üye Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
