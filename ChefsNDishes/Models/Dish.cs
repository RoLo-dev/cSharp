using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage="Name should be more than 2 characters")]
        public string DishName {get;set;}

        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}

        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        public int Calories {get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "Please be more detailed")]
        public string Description {get;set;}

        public int ChefId {get;set;}
        public Chef Creator {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}