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
    public class AylarManager : IAylarService
    {
        IAylarDal _aylarDal;

        public AylarManager(IAylarDal aylarDal)
        {
            _aylarDal = aylarDal;
        }

        public List<string> GetAylar()
        {
            // Veritabanındaki tüm iller varlıklarının listesi.
            return _aylarDal.GetAylar();
        }

        public List<Aylar> GetList()
        {
            //veri tabanında bulunan tüm ay varlıklarını listeler
            return _aylarDal.GetAll();
        }

        public void TAdd(Aylar t)
        {
            // - t: Eklenmek istenen aylar varlığı veri tabanına eklenir.
            _aylarDal.Add(t);
        }

        public void TDelete(Aylar t)
        {
            //t: Silinmek istenen aylar varlığı veri tabanından silinir.
            _aylarDal.Delete(t);
        }

        public Aylar TGetById(int id)
        {
            //Belirtilen ID değerine sahip aylar varlığı.
            return _aylarDal.GetByID(id);
        }

        public void TUpdate(Aylar t)
        {
            //Belirtilen kimlik değerine sahip aylar varlığı veri tabanında güncellenir.
            _aylarDal.Update(t);
        }
    }
}
