using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Required]
        public String name { get; set; }

        [Required]
        public String sex { get; set; }

        [Required]
        public int age { get; set; }
        
        public List<PhysicalInfoRecord> physicalRecords { get; set; } 
    }
}
