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
    public class UyeManager : IUyeService
    {
        IUyeDal _uyeDal;

        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }

        public List<Uye> DurumaGoreUyeler(bool durum)
        {
            return _uyeDal.DurumaGoreUyeler(durum);
        }

        public List<Uye> GetList()
        {
            return _uyeDal.GetAll();
        }

        public List<Uye> KanGrubunaGoreUyeler(string kanGrubu)
        {
            return _uyeDal.KanGrubunaGoreUyeler(kanGrubu);
        }

        public List<Uye> SehreGoreUyeler(string sehir)
        {
            return _uyeDal.SehreGoreUyeler(sehir);
        }

        public void TAdd(Uye t)
        {
            _uyeDal.Add(t);
        }

        public void TDelete(Uye t)
        {
            _uyeDal.Delete(t);
        }

        public Uye TGetById(int id)
        {
            return _uyeDal.GetByID(id);
        }

        public void TUpdate(Uye t)
        {
            _uyeDal.Update(t);
        }
    }
}
