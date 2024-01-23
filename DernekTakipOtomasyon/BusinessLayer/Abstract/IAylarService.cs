using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.BusinessLayer.Abstract
{
    public interface IAylarService:IGenericService<Aylar>
    {
        // Aylar tablosundan ay adlarını liste olarak getirir.
        List<string> GetAylar();
    }
}
