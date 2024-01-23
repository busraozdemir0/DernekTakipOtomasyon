using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DernekTakipOtomasyon.DataAccessLayer.Abstract;
using DernekTakipOtomasyon.DataAccessLayer.Context;

namespace DernekTakipOtomasyon.DataAccessLayer.Concrete
{ 
    public class GenericRepository<T>: IGenericRepository<T> where T: class
    {
        //Veri tabanına erişmek için db nesnesi oluştururuz.    
        DernekTakipEntities db = new DernekTakipEntities();
        
        public T GetByID(int id)
        {
            //veri tabanında belirli bir varlık türü içerisinde belirtilen ID'ye göre belirtilen varlığı bulur
            return db.Set<T>().Find(id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            //Veritabanındaki belirli bir varlık türünün tüm varlıklarını liste olarak getirir.
            return db.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            // Belirtilen varlığı veritabanına ekleyerek veri tabanına kaydeder.
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            //Belirtilen varlığı veritabanında günceller ve veri tabanında olan değişiklikleri kaydeder.
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            // Belirtilen varlığı veritabanından siler ve veri tabanının son halini kaydeder.
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
    }
}
