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
    public class YetkiliManager : IYetkiliService
    {
        IYetkiliDal _yetkiliDal;

        public YetkiliManager(IYetkiliDal yetkiliDal)
        {
            _yetkiliDal = yetkiliDal;
        }

        public List<Yetkili> GetList()
        {
            return _yetkiliDal.GetAll();
        }

        public void TAdd(Yetkili t)
        {
            _yetkiliDal.Add(t);
        }

        public void TDelete(Yetkili t)
        {
            _yetkiliDal.Delete(t);
        }

        public Yetkili TGetById(int id)
        {
            return _yetkiliDal.GetByID(id);
        }

        public void TUpdate(Yetkili t)
        {
            _yetkiliDal.Update(t);
        }
    }
}
