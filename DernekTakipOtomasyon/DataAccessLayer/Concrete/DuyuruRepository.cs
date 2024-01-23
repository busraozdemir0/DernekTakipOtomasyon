using DernekTakipOtomasyon.DataAccessLayer.Abstract;
using DernekTakipOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DernekTakipOtomasyon.DataAccessLayer.Concrete
{
    public class DuyuruRepository : GenericRepository<Duyuru>, IDuyuruDal
    {
        //Duyuru interfacede herhangi bir metot olmadığı için burada da herhangi
        //bir metot yazılmamıştır sadece GenericRepository miras alınır
    }
}
