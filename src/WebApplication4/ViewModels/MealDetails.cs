using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class MealDetails
    {
        public Meal meal { get; set; }
        public IEnumerable<FoodCalculator> regists { get; set; }
    }
}
