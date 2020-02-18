using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    [NotMapped]
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email address:")]
        public string LogEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string LogPassword {get;set;}
    }
}