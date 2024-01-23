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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        DernekTakipEntities db = new DernekTakipEntities();
        UyeManager uyeManager = new UyeManager(new UyeRepository());
        AidatManager aidatManager = new AidatManager(new AidatRepository());
        private void Raporlar_Load(object sender, EventArgs e)
        {
            illerManager illermanager = new illerManager(new illerRepository());
            
            //comboboxta illerin listelenmesi
            var sehirler = illermanager.GetSehir();

            for (int i = 0; i < sehirler.Count; i++)
            {
                cmbSehir.Items.Add(sehirler[i]);
            }

        }
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxta bulunan iilerden istediğimizi seçince o ile ait olan üyelerin listelenmesi
            var uyeler = uyeManager.SehreGoreUyeler(cmbSehir.Text);
            dtgrdSehir.DataSource = uyeler;
        }

        private void cmbKanGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxda bulunan kan gruplarından birini seç,nce o kan gurubuna ait olan üyelerin listelenmesi
            var uyeler = uyeManager.KanGrubunaGoreUyeler(cmbKanGrup.Text);
            dtgrdKanGrubu.DataSource = uyeler;
        }

        private void rdbtnAktif_CheckedChanged(object sender, EventArgs e)
        {
            //radio buttonlardan aktif olan seçilince durumu aktif olan üyelerin listelenmesi
            var uyeler = uyeManager.DurumaGoreUyeler(true);
            dtgrdDurum.DataSource = uyeler;
        }

        private void rdbtnPasif_CheckedChanged(object sender, EventArgs e)
        {
            //radio buttonlardan pasif olan seçilince durumu aktif olan üyelerin listelenmesi
            var uyeler = uyeManager.DurumaGoreUyeler(false);
            dtgrdDurum.DataSource = uyeler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //datetimepickerlarda seçilen iki tarih arasında olan üyelerin listelenmesi
            var tarih = aidatManager.TariheGoreOdemeler(dateTimePicker1.Value.ToString(),dateTimePicker2.Value.ToString());
            dtgrdTarih.DataSource = tarih;

        }
    }
}
