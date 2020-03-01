using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieReviews.Models
{
    public class Movie
    {
        [Key]
        public int MovieId {get;set;}
        public List<Review> MovieReviews {get;set;}

        [Required(ErrorMessage="Enter a movie name")]
        [Display(Name="Movie name:")]
        public string MovieName {get;set;}

        [Required(ErrorMessage="Enter the genre of the movie")]
        [Display(Name="Genre:")]
        [MinLength(2, ErrorMessage="Genre should be more than 2 characters")]
        public string Genre {get;set;}

        [Required(ErrorMessage="Enter the director's name")]
        [MinLength(4, ErrorMessage="Director's name should be more than 4 characters long")]
        public string Director {get;set;}

        [Required(ErrorMessage="Enter a date")]
        [Display(Name="Release date:")]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate {get;set;}

        [Required(ErrorMessage="Enter a url for the movie cover")]
        [Display(Name="url for movie cover:")]
        public string URL {get;set;}

        [Required(ErrorMessage="Enter a description of the movie")]
        [Display(Name="Description")]
        public string Desc {get;set;}

        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
    }
}