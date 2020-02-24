using System;
using System.ComponentModel.DataAnnotations;

namespace MovieReviews.Models
{
    public class Review
    {
        [Key]
        public int ReviewId {get;set;}
        public int UserId {get;set;}
        public int MovieId {get;set;}

        [Required(ErrorMessage="Enter a title for your review")]
        [Display(Name="Review title:")]
        [MinLength(2, ErrorMessage="Title should be more than 2 characters long")]
        public string ReviewTitle {get;set;}

        [Required(ErrorMessage="Enter your rating")]
        [Display(Name="Rating:")]
        [Range(1,5)]
        public int Rating {get;set;}

        [Required(ErrorMessage="Please leave a review")]
        [Display(Name="Review:")]
        [MinLength(5, ErrorMessage="Please more descriptive with your review")]
        public string Message {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}