using DernekTakipOtomasyon.DataAccessLayer.Abstract;
using DernekTakipOtomasyon.DataAccessLayer.Context;
using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.DataAccessLayer.Concrete
{
    public class UyeRepository : GenericRepository<Uye>, IUyeDal
    {
        DernekTakipEntities db = new DernekTakipEntities();

        public List<Uye> DurumaGoreUyeler(bool durum)
        {
            // LINQ sorgusu ile veritabanından duruma göre üyeleri filtreleyip, liste olarak getiriyor.
            return db.Uye.Where(x => x.Durum.Equals(durum)).ToList();
        }

        public List<Uye> KanGrubunaGoreUyeler(string kanGrubu)
        {
            // LINQ sorgusu ile veritabanından kan grubuna göre üyeleri filtreleyip, liste olarak getiriyor.
            return db.Uye.Where(x => x.KanGrubu.Equals(kanGrubu)).ToList();
        }

        public List<Uye> SehreGoreUyeler(string sehir)
        {
            // LINQ sorgusu ile veritabanından şehre göre üyeleri filtreleyip, liste olarak getiriyor.
            return db.Uye.Where(x => x.Sehir.Equals(sehir)).ToList();
        }
    }
}
