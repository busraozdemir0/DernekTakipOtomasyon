using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.Models
{
    public class Duyuru
    {
        [Key]
        public int ID { get; set; }
        public string YetkiliAdi { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public int YetkiliID { get; set; }
        [NotMapped]
        public Yetkili Yetkili { get; set; }
    }
}
