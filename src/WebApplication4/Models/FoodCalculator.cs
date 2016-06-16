using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class FoodCalculator
    {
        
        
        [Required]
        public int Id { get; set; }

        [Required]
        public String FoodName { get; set; }

        public String OwnerId { get; set; }
    
        [ForeignKey("OwnerId")]
        public ApplicationUser Owner { get; set; }

        public int FoodQuantity { get; set; }

        public int Grams { get; set; }

        public int Calories { get; set; }

        public int Lipid { get; set; }
        
    }
}
