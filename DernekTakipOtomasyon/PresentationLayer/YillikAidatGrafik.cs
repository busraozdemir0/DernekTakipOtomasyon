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
    public partial class YillikAidatGrafik : Form
    {
        public YillikAidatGrafik()
        {
            InitializeComponent();
        }
        private void BtnAyListele_Click(object sender, EventArgs e)
        {
            DernekTakipEntities db = new DernekTakipEntities();

            // LINQ sorgusu
            var yillikToplamlar = db.Aidat
                .GroupBy(a => new { Yil = a.OdemeTarihi.Year })
                .Select(g => new { Yil = g.Key.Yil, ToplamMiktar = g.Sum(a => a.Miktar) });

            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.CurveList.Clear(); // Önceki grafikleri temizle

            // Grafik başlıkları
            graphPane.Title.Text = "Yıllık Aidat Miktarları";
            graphPane.XAxis.Title.Text = "Yıllar";
            graphPane.YAxis.Title.Text = "Toplam Miktar (TL)";

            //X Ekseni
            string[] xLabels = yillikToplamlar.Select(item => $"{item.Yil}").ToArray();
            double[] xValues = Enumerable.Range(1, yillikToplamlar.Count()).Select(Convert.ToDouble).ToArray();

            //Y Ekseni
            double[] yValues = yillikToplamlar.Select(item => Convert.ToDouble(item.ToplamMiktar)).ToArray();

            // Çubuk grafik oluştur
            BarItem barItem = graphPane.AddBar("Toplam Miktar", null, yValues, System.Drawing.Color.Pink);

            // X ekseni etiketlerini ayarla
            graphPane.XAxis.Scale.TextLabels = xLabels;
            graphPane.XAxis.Type = AxisType.Text; // X ekseni tipini metin olarak ayarla
            graphPane.XAxis.Scale.Max = xValues.Max() + 1;

            // Grafiği güncelle
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
}
