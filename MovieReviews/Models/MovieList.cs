using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviews.Models
{
    [NotMapped]
    public class MovieList
    {
        public List<Movie> MovieLibrary {get;set;}
        public Movie MovieToAdd {get;set;}
        public List<Review> MovieReviews {get;set;}
        public Review ReviewToAdd {get;set;}
    }
}