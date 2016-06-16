using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ChangeInfoViewModel
    {
        [Display(Name = "New weight")]
        public decimal New_Weight { get; set; }

        [Display(Name = "New heigth")]
        public decimal New_Height { get; set; }

        public List<PhysicalInfoRecord> physicalRecords { get; set; }

    }
}
