using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{[Table("tblSorular")] //db'de oluşacak tablonun adı 
   public class Soru
    {
        [Key]
        public int SoruID { get; set; }
        [Required]//Soru cümlesi zorunlu
        public string SoruCumlesi { get; set; }

    }
}
