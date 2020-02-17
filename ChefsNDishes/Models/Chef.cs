using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "Name should be more than 2 characters")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2, ErrorMessage = "Last name should be more than 2 characters")]
        public string LastName {get;set;}

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth {get;set;}

        public List<Dish> CreatedDishes {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}