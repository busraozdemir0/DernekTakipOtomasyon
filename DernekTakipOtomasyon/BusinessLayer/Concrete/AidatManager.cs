using DernekTakipOtomasyon.BusinessLayer.Abstract;
using DernekTakipOtomasyon.DataAccessLayer.Abstract;
using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.BusinessLayer.Concrete
{
    public class AidatManager : IAidatService
    {
        //veri tabanı erişim işlemleri için kullanılacak veri erişim katmanı
        IAidatDal _aidatDal;

        public AidatManager(IAidatDal aidatDal)
        {
            _aidatDal = aidatDal;
        }

        public List<Aidat> GetList()
        {
            // Veritabanındaki tüm Aidat varlıklarının listesi.
            return _aidatDal.GetAll();
        }

        public void TAdd(Aidat t)
        {
            // - t: Eklenmek istenen Aidat varlığı veri tabanına eklenir.
            _aidatDal.Add(t);
        }

        public List<Aidat> TariheGoreOdemeler(string baslangic, string bitis)
        {
            //Belirtilen tarih aralığına uyan Aidat varlıklarının listesi.
            return _aidatDal.TariheGoreOdemeler(baslangic, bitis);
        }

        public void TDelete(Aidat t)
        {
            //t: Silinmek istenen Aidat varlığı veri tabanından silinir.
            _aidatDal.Delete(t);
        }

        public Aidat TGetById(int id)
        {
            //Belirtilen ID değerine sahip Aidat varlığı.
            return _aidatDal.GetByID(id);
        }

        public void TUpdate(Aidat t)
        {
            //Belirtilen kimlik değerine sahip Aidat varlığı veri tabanında güncellenir.
            _aidatDal.Update(t);
        }
    }
}
