using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.DataAccessLayer.Abstract
{
    public interface IAylarDal : IGenericRepository<Aylar>
    {
        //Aylar varlığında bulunan tüm ayların listelenmesini sağlar
        List<string> GetAylar();
    }
}
