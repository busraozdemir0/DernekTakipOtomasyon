using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.Models
{
    public class Yetkili
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }      
        public List<Duyuru> Duyurus { get; set; }

    }
}
