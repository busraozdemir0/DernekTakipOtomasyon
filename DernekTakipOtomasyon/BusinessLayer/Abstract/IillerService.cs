using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace DernekTakipOtomasyon.BusinessLayer.Abstract
{
    public interface IillerService : IGenericService<iller>
    {
        // iller tablosunda bulunan sehir adlarını liste olarak getirir
        List<string> GetSehir();
    }
}
