using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [Display(Name="First name:")]
        [MinLength(2, ErrorMessage="Name should be more than 2 characters")]
        public string FirstName {get;set;}

        [Required]
        [Display(Name="Last name:")]
        [MinLength(2, ErrorMessage="Last name should be more than 2 characters")]
        public string LastName {get;set;}

        [Required]
        [EmailAddress]
        [Display(Name="Email address:")]
        public string Email {get;set;}

        [Required]
        [Display(Name="Password:")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage="Password should be more than 5 characters long")]
        public string Password {get;set;}

        [NotMapped]
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm password:")]
        public string Confirm {get;set;}
        
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Transaction> UserTransactions {get; set;}
    }
}