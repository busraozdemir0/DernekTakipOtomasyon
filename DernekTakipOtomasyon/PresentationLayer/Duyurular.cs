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
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }
        // Duyuru tablosu için oluşturulan mimariye erişebilmek adına nesne üretildi.
        DuyuruManager duyuruManager = new DuyuruManager(new DuyuruRepository());

        // Veri tabanından direkt olarak erişmemiz gerektiği durumlarda nesne üretildi.
        DernekTakipEntities db = new DernekTakipEntities();

        // Ekleme işlemi için Duyuru tablosundan nesne üretildi
        Duyuru duyuru = new Duyuru();

        void Listele()   // Veri ekleme işlemi sonrasında datagridview'daki bilgiler tekrardan listelensin
        {
            dataGridView1.DataSource = duyuruManager.GetList();

            // Datagrid'de listelenen alanlar içerisinde gözükmesini istemediğimiz alanların görünümü false yapıldı.
            dataGridView1.Columns["Yetkili"].Visible = false;  
            dataGridView1.Columns["YetkiliID"].Visible = false;  
        }
        void Temizle()  // Ekleme işlemi sonrası ilgili alanlarda bulunan bilgilerin temizlenmesi için
        {
            txtBaslik.Text = " ";
            txtAciklama.Text = " ";
            dateTimePicker1.Value= DateTime.Now; 
        }

        private void Duyurular_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Girilen kullanıcı adı Yetkili tablosunda bulunan kullanıcı adlarından biriyse o kişinin ID'sini al.
            var yetkiliID = db.Yetkili.Where(x => x.KullaniciAd.Equals(txtKullaniciAd.Text)).Select(y => y.ID).FirstOrDefault();

            // Girilen kullanıcı adı Yetkili tablosunda bulunan kullanıcı adlarından biriyse o kişinin kullanıcı adını al.
            var yetkiliAdi = db.Yetkili.Where(x => x.KullaniciAd.Equals(txtKullaniciAd.Text)).Select(y => y.KullaniciAd).FirstOrDefault();

            if (yetkiliAdi != null)  // Kullanıcı adı veritabanında varsa yani yetkiliAdi değişkeni boş değer döndürmüyorsa çalışacak
            {
                duyuru.YetkiliAdi = yetkiliAdi;
                duyuru.Baslik = txtBaslik.Text;
                duyuru.Tarih = dateTimePicker1.Value.Date;
                duyuru.Aciklama = txtAciklama.Text;
                duyuru.YetkiliID = yetkiliID;

                duyuruManager.TAdd(duyuru);

                Listele();

                Temizle();

                MessageBox.Show("Başarıyla eklendi.", "Duyuru Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else  // Girilen kullanıcı adına ait veritabanında kayıt yoksa çalışacak
            {
                MessageBox.Show("Kullanıcı adını hatalı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAd.Text = "";
                txtBaslik.Text = "";
                txtAciklama.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagrid'de listelenen alanlar içerisinde gözükmesini istemediğimiz alanların görünümü false yapıldı.
            dataGridView1.Columns["Yetkili"].Visible = false;
            dataGridView1.Columns["YetkiliID"].Visible = false;
            
            //Datagrid'de seçilen duyuru bilgilerinin gerekli textboxlarda görüntülenmesi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKullaniciAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBaslik.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtAciklama.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[4].Value);

        }
    }
}
