using System.ComponentModel.DataAnnotations;
namespace ValidatingForm.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string FirstName{get;set;}

        [Required]
        [MinLength(2)]
        public string LastName{get;set;}

        [Required]
        public string Age{get;set;}

        [Required]
        [MinLength(4)]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(4)]
        public string Password{get;set;}
    }
}