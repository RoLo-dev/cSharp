using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviews.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        public List<Review> Reviews {get;set;}

        [Required(ErrorMessage="Please enter your name")]
        [Display(Name="First name:")]
        [MinLength(2, ErrorMessage="Name should be more than 2 characters")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage="Please enter a valid name")]
        public string FirstName {get;set;}

        [Required(ErrorMessage="Please enter your last name")]
        [Display(Name="Last name:")]
        [MinLength(2, ErrorMessage="Last name should be more than 2 characters")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage="Please enter a valid last name")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Please enter an email")]
        [Display(Name="Email:")]
        [EmailAddress]
        [MinLength(4, ErrorMessage="Email address should be more than 4 characters")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage="Please enter a valid email address")]
        public string Email {get;set;}

        [Required(ErrorMessage="Please enter a password between 8-15 characters")]
        [Display(Name="Password:")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", ErrorMessage="Password should contain a number and Uppercase letter")]
        public string Password {get;set;}

        [NotMapped]
        [Required(ErrorMessage="Confirm password")]
        [Display(Name="Confirm password:")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage="Passwords don't match")]
        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}