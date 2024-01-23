using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        //verilen bir varlığı oluşturup veri tabanına ekler.
        void TAdd(T t);
        //verilen varlığın silinip veri tabanından da kaldırılmasını sağlar.
        void TDelete(T t);
        //verilen varlığı güncelleyip veri tabanı üzerinde de güncellenmesini sağlar.
        void TUpdate(T t);
        //veri tabanında bulunan belirli varlık türüne ait tüm varlıkları getirmesini sağlar.
        List<T> GetList();
        //veri tabanında bir varlığı belirtilen ID değerine göre getirmesini sağlar
        T TGetById(int id);
    }
}
