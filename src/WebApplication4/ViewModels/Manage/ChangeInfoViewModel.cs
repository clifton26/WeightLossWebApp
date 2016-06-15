using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.ViewModels.Manage
{
    public class ChangeInfoViewModel
    {
        [Required]
        [Display(Name = "New weight")]
        public int NewWeight { get; set; }

        [Required]
        [Display(Name = "New height")]
        public int NewHeight { get; set; }
    }
}
