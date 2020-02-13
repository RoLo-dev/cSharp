using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        [Display(Name = "Chef's Name")]
        public string Chef {get;set;}

        [Required]
        [Display(Name = "Name of dish")]
        public string Name {get;set;}

        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}

        [Required]
        [Display(Name = "# of Calories")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        public int Calories {get;set;}

        [Required]
        public string Description {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}