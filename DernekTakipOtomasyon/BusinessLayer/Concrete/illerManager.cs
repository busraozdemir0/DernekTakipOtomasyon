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
    public class illerManager : IillerService
    {
        IillerDal _illerDal;

        public illerManager(IillerDal illerDal)
        {
            _illerDal = illerDal;
        }

        public List<iller> GetList()
        {
            return _illerDal.GetAll();
        }

        public List<string> GetSehir()
        {
           return _illerDal.GetSehir();
        }

        public void TAdd(iller t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(iller t)
        {
            throw new NotImplementedException();
        }

        public iller TGetById(int id)
        {
            return _illerDal.GetByID(id);
        }

        public void TUpdate(iller t)
        {
            throw new NotImplementedException();
        }
    }
}
