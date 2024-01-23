using DernekTakipOtomasyon.BusinessLayer.Concrete;
using DernekTakipOtomasyon.DataAccessLayer.Concrete;
using DernekTakipOtomasyon.DataAccessLayer.Context;
using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekTakipOtomasyon.PresentationLayer
{
    public partial class AidatIslemleri : Form
    {
        public AidatIslemleri()
        {
            InitializeComponent();
        }
        // Aidat tablosu için oluşturulan mimariye erişebilmek adına nesne üretildi.
        AidatManager aidatManager = new AidatManager(new AidatRepository());

        // Veri tabanından direkt olarak erişmemiz gerektiği durumlarda nesne üretildi.
        DernekTakipEntities db = new DernekTakipEntities();

        // Ekleme işlemi için Uye tablosundan nesne üretildi
        Aidat aidat = new Aidat();
        void Temizle() // Güncelleme ve silme işlemi sonrası ilgili alanlarda bulunan bilgilerin temizlenmesi için
        {
            msktxtTc.Text = " ";
            cmbAylar.Text = "";
            txtMiktar.Text = " ";
            rdbtnAktif.Checked = false;
            rdbtnPasif.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        void Listele() // Veri ekleme, silme, güncelleme işlemi sonrasında datagridview'daki bilgiler tekrardan listelensin
        {
            dataGridAidat.DataSource = aidatManager.GetList();

            // Datagrid'de listelenen alanlar içerisinde gözükmesini istemediğimiz alanların görünümü false yapıldı.
            dataGridAidat.Columns["Uye"].Visible = false;
        }
        private void AidatIslemleri_Load(object sender, EventArgs e)
        {
            Listele();

            // Sayfa yüklendiğinde aylar combobox'a gelmesi için
            AylarManager aylarManager = new AylarManager(new AylarRepository());

            var aylar = aylarManager.GetAylar();

            for (int i = 0; i < aylar.Count; i++)
            {
                cmbAylar.Items.Add(aylar[i]);
            }

            // Aidat bilgisi için listelenen üyeler arasından seçim yaparak ekleme yapılabilir.
            UyeManager uyeManager = new UyeManager(new UyeRepository());
            dataGridUye.DataSource = uyeManager.GetList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var uyeTC = msktxtTc.Text;

            // Girilen TC'ye ait kişinin ID bilgisini çek
            var uyeID = db.Uye.Where(x => x.TC.Equals(uyeTC)).Select(y => y.ID).FirstOrDefault();

            // Eğer girilen TC veri tabanında yoksa uyeID 0 dönecektir ve 0 dönüyorsa da ekleme işlemine izin verilmemektedir.
            if (uyeID == 0)
            {
                MessageBox.Show("Girilen TC kimlik numaralı üye veri tabanında bulunmamaktadır!", "Hata", 
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Temizle();
            }
            else
            {
                aidat.UyeID = uyeID;
                aidat.OdemeTarihi = dateTimePicker1.Value.Date;
                aidat.Miktar = Convert.ToDecimal(txtMiktar.Text);
                if (rdbtnAktif.Checked) // Aktif adlı buton seçiliyse
                {
                    aidat.Durum = true; // Durum alanına true değerini kaydet
                }
                else // Pasif adlı buton seçiliyse
                {
                    aidat.Durum = false; // Durum alanına false değerini kaydet
                }

                aidatManager.TAdd(aidat);

                Listele();

                Temizle();

                MessageBox.Show("Başarıyla eklendi.", "Aidat Bilgisi Ekleme", 
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void cmbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combobox'ta listelenen aylar arasında hangisi seçildiyse o aya ait aidat miktarının değeri+
            //txtMiktar adlı textbox'a otomatik getirilecektir.

            string ayAdi = cmbAylar.Text;
            var miktar = db.Aylar.Where(x => x.AyAdi == ayAdi).Select(y => y.Tutar).FirstOrDefault();
            txtMiktar.Text = miktar.ToString();
        }

        private void dataGridAidat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagrid'de listelenen alanlar içerisinde gözükmesini istemediğimiz alanların görünümü false yapıldı.
            dataGridAidat.Columns["Uye"].Visible = false;

            int secilen = dataGridAidat.SelectedCells[0].RowIndex;
            txtMiktar.Text = dataGridAidat.Rows[secilen].Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridAidat.Rows[secilen].Cells[2].Value);

            // Listelenen Aidat kayıtları arasından seçilen kaydın Ay bilgisini combobox'da gösterme
            var ay = Convert.ToDateTime(dataGridAidat.Rows[secilen].Cells[2].Value);
            int ayNo = ay.Month;
            var ayAdi = db.Aylar.Where(x => x.ID == ayNo).Select(y => y.AyAdi).FirstOrDefault();
            cmbAylar.Text = ayAdi.ToString();

            // Listelenen Aidat kayıtları arasından seçilen kaydın TC bilgisini TC için ayrılmış alanda gösterme
            var uyeID = Convert.ToInt32(dataGridAidat.Rows[secilen].Cells[4].Value);
            var kisiTC = db.Uye.Where(x => x.ID.Equals(uyeID)).Select(y => y.TC).FirstOrDefault();
            msktxtTc.Text = kisiTC.ToString();

            if (dataGridAidat.Rows[secilen].Cells[3].Value.ToString() == "True")
            {
                rdbtnAktif.Checked = true;
            }
            else if (dataGridAidat.Rows[secilen].Cells[3].Value.ToString() == "False")
            {
                rdbtnPasif.Checked = true;
            }
        }

        private void dataGridUye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridUye.SelectedCells[0].RowIndex;
            msktxtTc.Text = dataGridUye.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            var aidatID = dataGridAidat.SelectedCells[0].RowIndex;

            var aidat = aidatManager.TGetById(aidatID+1); // Seçilen kaydın indexi 0'dan başladığı için +1 eklendi.

            if (!aidat.Durum)  // Aidat durumu false ise çalışacak
            {
                aidat.Durum = true;
                aidatManager.TUpdate(aidat);

                MessageBox.Show("Aidat kaydı aktif olarak güncellendi.", "Aktif Yap", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listele();
            }
            else
            {
                MessageBox.Show("Seçilen kayıt aktif durumdadır!", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
    }
}
