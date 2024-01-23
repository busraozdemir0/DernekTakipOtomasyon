using DernekTakipOtomasyon.DataAccessLayer.Abstract;
using DernekTakipOtomasyon.DataAccessLayer.Context;
using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekTakipOtomasyon.DataAccessLayer.Concrete
{
    public class AidatRepository : GenericRepository<Aidat>, IAidatDal
    {
        DernekTakipEntities db = new DernekTakipEntities();

        public List<Aidat> TariheGoreOdemeler(string baslangic, string bitis)
        {
            // LINQ sorgusu ile veritabanından ödemeleri tarih aralığına göre filtreleyip liste olarak getiriyor.
            return db.Aidat.Where(x => x.OdemeTarihi >= Convert.ToDateTime(baslangic) && x.OdemeTarihi <= Convert.ToDateTime(bitis)).ToList();
        }
    }
}
