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
    public partial class AidatDuzenle : Form
    {
        public AidatDuzenle()
        {
            InitializeComponent();
        }

        // Aylar tablosu için oluşturulan mimariye erişebilmek adına nesne üretildi.
        AylarManager aylarManager = new AylarManager(new AylarRepository());

        // Veri tabanından direkt olarak erişmemiz gerektiği durumlarda nesne üretildi.
        DernekTakipEntities db = new DernekTakipEntities();

        void Temizle()  // Güncelleme işlemi sonrası ilgili alanlarda bulunan bilgilerin temizlenmesi için
        {
            cmbAylar.Text = "";
            txtTutar.Text = "";
        }
        private void AidatDuzenle_Load(object sender, EventArgs e)
        {
            dataGridAidat.DataSource = aylarManager.GetList();

            // Sayfa yüklendiğinde aylar combobox'a gelmesi için
            var aylar = aylarManager.GetAylar();

            for (int i = 0; i < aylar.Count; i++)
            {
                cmbAylar.Items.Add(aylar[i]);
            }
        }

        private void dataGridAidat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridAidat.SelectedCells[0].RowIndex;
            cmbAylar.Text = dataGridAidat.Rows[secilen].Cells[1].Value.ToString();
            txtTutar.Text = dataGridAidat.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var secilen = cmbAylar.SelectedIndex;  // Combobox'tan seçilen ay isminin index değeri secilen'e atandı.

            var guncelleme = aylarManager.TGetById(secilen + 1);  // Combobox'tan seçilen index 0'dan başladığı için +1 eklenerek verinin getirilmesi.

            guncelleme.AyAdi = cmbAylar.Text;
            guncelleme.Tutar = Convert.ToDecimal(txtTutar.Text);

            aylarManager.TUpdate(guncelleme);

            dataGridAidat.DataSource = aylarManager.GetList();

            MessageBox.Show("Başarıyla güncellendi.", "Aidat Ücret Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Temizle();
        }
    }
}
