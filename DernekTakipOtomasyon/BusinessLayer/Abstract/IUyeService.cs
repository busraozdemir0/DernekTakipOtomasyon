using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.BusinessLayer.Abstract
{
    public interface IUyeService:IGenericService<Uye>
    {
        //Belirtilen şehre göre üyeleri listeler
        List<Uye> SehreGoreUyeler(string sehir);
        //Belirtilen kangrubuna göre üyeleri listeler
        List<Uye> KanGrubunaGoreUyeler(string kanGrubu);
        //Belirtilen duruma göre üyeleri listeler
        List<Uye> DurumaGoreUyeler(bool durum);
    }
}
