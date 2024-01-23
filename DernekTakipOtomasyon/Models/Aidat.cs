using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.Models
{
    public class Aidat
    {
        [Key]
        public int ID { get; set; }
        [StringLength(11, ErrorMessage = "TC alanı 11 karakterden az veya daha fazla olamaz.")]
        public decimal Miktar { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public bool Durum { get; set; }
        public int UyeID { get; set; }
        [NotMapped]
        public Uye Uye { get; set; }
    }
}
