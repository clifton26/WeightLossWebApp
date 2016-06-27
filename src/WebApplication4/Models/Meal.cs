using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Meal
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public String OwnerId { get; set; }
        
        [ForeignKey("OwnerId")]
        public ApplicationUser Owner { get; set; }

        public String MealName { get; set; }

        public int totalCalories { get; set; }

        public int totalLipids { get; set; }

        public int quantity { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime recordDate { get; set; }


    }
}
