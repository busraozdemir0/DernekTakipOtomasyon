using DernekTakipOtomasyon.DataAccessLayer.Abstract;
using DernekTakipOtomasyon.DataAccessLayer.Context;
using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.DataAccessLayer.Concrete
{
    public class illerRepository : GenericRepository<iller>, IillerDal
    {
        DernekTakipEntities db=new DernekTakipEntities();
        public List<string> GetSehir()
        {
            // LINQ sorgusu ile veritabanından iller tablosundaki şehir adlarını çekip liste olarak getiriyor.
            return db.iller.Select(y=>y.sehir).ToList();
        }
    }
}
