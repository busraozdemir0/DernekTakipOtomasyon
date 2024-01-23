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
    public class AylarRepository : GenericRepository<Aylar>, IAylarDal
    {
        DernekTakipEntities db = new DernekTakipEntities();

        public List<string> GetAylar()
        {
            // LINQ sorgusu ile veritabanından Aylar tablosundaki ay adlarını çekip liste olarak getiriyor.
            return db.Aylar.Select(y=>y.AyAdi).ToList();
        }
    }
}
