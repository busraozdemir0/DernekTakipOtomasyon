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
    public partial class AnaSayfa : Form
    {
        
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UyeIslemleri uyesayfa = new UyeIslemleri();
            uyesayfa.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AidatIslemleri aidatislem = new AidatIslemleri();
            aidatislem.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Duyurular duyuru = new Duyurular();
            duyuru.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AidatDuzenle aidatduzenle = new AidatDuzenle();
            aidatduzenle.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Uygulamadan çıkış işlemi için
            Application.Exit();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Borclular borclular = new Borclular();
            borclular.Show();
        }

        private void aylıkAidatGelirGrafiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AylikAidatGrafik aylikAidatGrafik = new AylikAidatGrafik();
            aylikAidatGrafik.Show();
        }

        private void yıllıkAidatGrafiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YillikAidatGrafik yillikAidatGrafik = new YillikAidatGrafik();
            yillikAidatGrafik.Show();
        }

        private void şehirlereGöreÜyeGrafiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SehireGoreUyeGrafigi sehireGoreUyeGrafigi = new SehireGoreUyeGrafigi();
            sehireGoreUyeGrafigi.Show();
        }
    }
}
