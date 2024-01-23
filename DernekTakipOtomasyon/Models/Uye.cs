using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.Models
{
    public class Uye
    {
        [Key]
        public int ID { get; set; }
        
        [StringLength(11, ErrorMessage = "TC alanı 11 karakterden az veya daha fazla olamaz.")]
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Sehir { get; set; }
        public string KanGrubu { get; set; }
        public string EMail { get; set; }
        public bool Durum { get; set; }
        public List<Aidat> Aidats { get; set; }
    }
}
