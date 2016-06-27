using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class FoodsCalculator
    {

        public int foodId { get; set; }
        public IEnumerable<SelectListItem> selectList { get; set; }
        public Meal meal { get; set; } 
        public FoodCalculator calculator { get; set; }

    }
}
