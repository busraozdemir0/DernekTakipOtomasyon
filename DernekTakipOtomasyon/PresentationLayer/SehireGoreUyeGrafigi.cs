using DernekTakipOtomasyon.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DernekTakipOtomasyon.PresentationLayer
{
    public partial class SehireGoreUyeGrafigi : Form
    {
        public SehireGoreUyeGrafigi()
        {
            InitializeComponent();
        }

        private void BtnAyListele_Click(object sender, EventArgs e)
        {
            DernekTakipEntities db = new DernekTakipEntities();

            // LINQ sorgusu
            var sonuc = db.Uye.GroupBy(u => u.Sehir).Select(g => new { Sehir = g.Key, KisiSayisi = g.Count() });

            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.CurveList.Clear(); // Önceki grafikleri temizle

            graphPane.Title.Text = "Şehirdeki Toplam Kişi Sayısı";
            graphPane.XAxis.Title.Text = "Şehirler";
            graphPane.YAxis.Title.Text = "Toplam Kişi Sayısı";

            // X ekseni etiketleri ve değerleri
            string[] xLabels = sonuc.Select(item => item.Sehir).ToArray();
            double[] xValues = Enumerable.Range(1, sonuc.Count()).Select(Convert.ToDouble).ToArray();

            // Y ekseni değerleri
            double[] yValues = sonuc.Select(item => Convert.ToDouble(item.KisiSayisi)).ToArray();

            // Çubuk grafik oluştur
            BarItem barItem = graphPane.AddBar("Toplam Kişi Sayısı", null, yValues, System.Drawing.Color.DarkBlue);

            // X ekseni etiketlerini ayarla
            graphPane.XAxis.Scale.TextLabels = xLabels;
            graphPane.XAxis.Type = AxisType.Text; // X ekseni tipini metin olarak ayarla
            graphPane.XAxis.Scale.Max = xValues.Max() + 1;

            // X ekseni etiketlerini daha iyi görünür hale getirme
            graphPane.XAxis.MajorTic.IsBetweenLabels = true;
            graphPane.XAxis.Scale.Align = AlignP.Inside;

            // Grafiği güncelle
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

        }
    }
}
