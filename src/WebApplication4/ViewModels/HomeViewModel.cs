using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<PhysicalInfoRecord> physicalRecords { get; set; }
        public IEnumerable<FoodCalculator> foodRecords { get; set; }
        public ApplicationUser user { get; set; }
    }
}
