using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(18, 99, ErrorMessage = "Please enter a valid number!")]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Height")]
        public int Height { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public int Weight { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

    }
}
