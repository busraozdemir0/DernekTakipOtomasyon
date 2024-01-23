using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.BusinessLayer.Abstract
{
    public interface IAidatService:IGenericService<Aidat>
    {
        // Belirli bir tarih aralığına göre ödemeleri getirmek için kullanılır.
        List<Aidat> TariheGoreOdemeler(string baslangic, string bitis);
    }
}
