using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DernekTakipOtomasyon.Models;

namespace DernekTakipOtomasyon.DataAccessLayer.Abstract
{
    public interface IAidatDal : IGenericRepository<Aidat>
    {
        //başlangıç ve bitiş parametrelerini alarak bu tarih arasındaki ödemeleri liste olarak döndürür
        List<Aidat> TariheGoreOdemeler(string baslangic, string bitis);
    }
}
