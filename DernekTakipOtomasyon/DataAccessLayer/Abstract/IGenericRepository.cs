using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T>
    {
       
        T GetByID(int id); //Belirli ID'ye sahip olan varlığı getirir    
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Belirli filtreleme kriterine göre varlık getirir
        void Add(T entity); //Yeni varlık ekleme
        void Update(T entity);//Mevcut bulunan varlık üzerinde güncelleme işlemi
        void Delete(T entity);//Mevcut bulunan varlığı silmek için kullanılır
        
    }
}
