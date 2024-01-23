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
    public class DuyuruManager : IDuyuruService
    {
        IDuyuruDal _duyuruDal;

        public DuyuruManager(IDuyuruDal duyuruDal)
        {
            _duyuruDal = duyuruDal;
        }
        public List<Duyuru> GetList()
        {
            // Veritabanındaki tüm duyuru varlıklarının listesi.
            return _duyuruDal.GetAll();
        }

        public void TAdd(Duyuru t)
        {
            // - t: Eklenmek istenen duyuru varlığı veri tabanına eklenir.
            _duyuruDal.Add(t);
        }

        public void TDelete(Duyuru t)
        {
            //t: Silinmek istenen duyuru varlığı veri tabanından silinir.
            _duyuruDal.Delete(t);
        }

        public Duyuru TGetById(int id)
        {
            //Belirtilen ID değerine sahip duyuru varlığı.
            return _duyuruDal.GetByID(id);
        }

        public void TUpdate(Duyuru t)
        {
            //t: güncellenmek istenen duyuru varlığı veri tabanında güncellenir.
            _duyuruDal.Update(t);
        }
    }
}
