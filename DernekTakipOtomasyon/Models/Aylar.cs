using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.Models
{
    public class Aylar
    {
        [Key]
        public int ID { get; set; }
        public string AyAdi { get; set; }
        public decimal Tutar { get; set; }
    }
}
