using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}

        [Required]
        [Display(Name="Deposit/Withdrawal")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString="{0:0.###}")]
        public decimal Amount {get;set;}

        public int UserId {get;set;}
        public User Owner {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}