using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.DataAccessLayer.Abstract
{
    public interface IUyeDal : IGenericRepository<Uye>
    {
        //Belirli şehre ait olan üyeleri liste olarak döndürür
        List<Uye> SehreGoreUyeler(string sehir);
        //Belirli kan grubuna ait olan üyeleri liste olarak döndürür
        List<Uye> KanGrubunaGoreUyeler(string kanGrubu);
        //Durumun aktif veya pasif olmasına göre üyeleri liste olarak döndürür
        List<Uye> DurumaGoreUyeler(bool durum);
    }
}
