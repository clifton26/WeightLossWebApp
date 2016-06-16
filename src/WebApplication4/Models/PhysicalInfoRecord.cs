using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class PhysicalInfoRecord
    {


        public int id { get; set; }

        public String OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public ApplicationUser Owner { get; set; }

        [Required]
        public decimal weight { get; set; }

        [Required]
        public decimal height { get; set; }

        [Required]
        public decimal imc { get; set; }
    
        [Required]
        public DateTime recordDate { get; set; }
    }
}
