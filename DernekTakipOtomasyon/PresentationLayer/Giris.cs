using DernekTakipOtomasyon.BusinessLayer.Concrete;
using DernekTakipOtomasyon.DataAccessLayer.Concrete;
using DernekTakipOtomasyon.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekTakipOtomasyon.PresentationLayer
{
    public partial class Giris : Form
    {
       
        public Giris()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Hesap oluştur butonuna basıldığında bizi kayıt sayfasına yönlendirir
            Kayit kayit = new Kayit();
            kayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {     
            DernekTakipEntities db = new DernekTakipEntities();

            //kullanıcı adı ve şifre birbirine uyuyor mu diye kontrol eden LINQ sorgusu
            var yetkili= db.Yetkili.FirstOrDefault(x => x.KullaniciAd == txtKullaniciAd.Text && x.Sifre == txtSifre.Text);

            if (yetkili != null)
            {
                MessageBox.Show("Giriş başarılı.", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();

                // Giriş yapan kişinin Yetkili ID'si
                var ID = db.Yetkili.Where(x => x.KullaniciAd.Equals(txtKullaniciAd.Text)).Select(y=>y.ID).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
