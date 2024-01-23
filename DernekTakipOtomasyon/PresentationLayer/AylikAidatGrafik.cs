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
    public partial class AylikAidatGrafik : Form
    {
        public AylikAidatGrafik()
        {
            InitializeComponent();
        }
       
        private void BtnAyListele_Click(object sender, EventArgs e)
        {
            DernekTakipEntities db = new DernekTakipEntities();
            // LINQ sorgusu
            var aylikToplamlar = db.Aidat
                .GroupBy(a => new { Ay = a.OdemeTarihi.Month })
                .Select(g => new { Ay = g.Key.Ay, ToplamMiktar = g.Sum(a => a.Miktar) });

            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.CurveList.Clear(); // Önceki grafikleri temizle

            // Grafik başlıkları
            graphPane.Title.Text = "Aylık Aidat Miktarları";
            graphPane.XAxis.Title.Text = "Aylar";
            graphPane.YAxis.Title.Text = "Toplam Miktar (TL)";

            //X Ekseni
            string[] xLabels = aylikToplamlar.Select(item => $"{item.Ay}").ToArray();
            double[] xValues = Enumerable.Range(1, aylikToplamlar.Count()).Select(Convert.ToDouble).ToArray();

            //Y Ekseni
            double[] yValues = aylikToplamlar.Select(item => Convert.ToDouble(item.ToplamMiktar)).ToArray();

            // Çubuk grafik oluştur
            BarItem barItem = graphPane.AddBar("Toplam Miktar", null, yValues, System.Drawing.Color.Purple);

            // X ekseni etiketlerini ayarla
            graphPane.XAxis.Scale.TextLabels = xLabels;
            graphPane.XAxis.Type = AxisType.Text; 
            graphPane.XAxis.Scale.Max = xValues.Max() + 1;

            // Grafiği güncelle
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
}
