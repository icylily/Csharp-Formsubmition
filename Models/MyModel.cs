using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "FirstName is required")]
        [MinLength(4)]
        [Display(Name = "FirstName:")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [MinLength(4)]
        [Display(Name = "LastName:")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "Age:")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }
    }
}