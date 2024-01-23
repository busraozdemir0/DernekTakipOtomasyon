using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DernekTakipOtomasyon.Models;

namespace DernekTakipOtomasyon.DataAccessLayer.Abstract
{
    public interface IillerDal : IGenericRepository<iller>
    {
        //iller varlığında bulunan tüm illerin listelenmesini sağlar
        List<string> GetSehir();
    }
}
