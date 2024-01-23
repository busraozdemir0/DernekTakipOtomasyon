using DernekTakipOtomasyon.BusinessLayer.Concrete;
using DernekTakipOtomasyon.DataAccessLayer.Abstract;
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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        // Yetkili tablosu için oluşturulan mimariye erişebilmek adına nesne üretildi.
        YetkiliManager yetkiliManager = new YetkiliManager(new YetkiliRepository());

        // Veri tabanından direkt olarak erişmemiz gerektiği durumlarda nesne üretildi.
        DernekTakipEntities db = new DernekTakipEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Yetkili yetkili = new Yetkili();
            yetkili.KullaniciAd = txtkullanici.Text;

            var kullaniciAdVar = db.Yetkili.Where(x => x.KullaniciAd.Equals(txtkullanici.Text)).FirstOrDefault();

            // Girilen kullanıcı adı veri tabanında varsa uyarı mesajı döndüren kod bloğu.
            if (kullaniciAdVar != null)
            {
                MessageBox.Show("Girilen kullanıcı adı alınmış. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtkullanici.Text = "";
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
            }

            // Kullanıcı adı önceden alınmamışsa çalışacak olan kod bloğu.
            else
            {
                if (txtSifre.Text == txtSifreTekrar.Text)  // Şifre alanları eşit girilmişse çalışır
                {
                    yetkili.Sifre = txtSifre.Text;
                    yetkiliManager.TAdd(yetkili);

                    Giris giris = new Giris();
                    giris.Show();

                    MessageBox.Show("Başarıyla kaydoldunuz.", "Kayıt Ol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
