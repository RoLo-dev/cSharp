using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviews.Models
{
    [NotMapped]
    public class Login
    {
        [Required(ErrorMessage="Please enter an email")]
        [Display(Name="Email:")]
        [EmailAddress]
        [MinLength(4, ErrorMessage="Email address should be more than 4 characters")]
        public string LogEmail {get;set;}

        [Required(ErrorMessage="Please enter a password between 8-15 characters")]
        [Display(Name="Password:")]
        [DataType(DataType.Password)]
        public string LogPassword {get;set;}
    }
}