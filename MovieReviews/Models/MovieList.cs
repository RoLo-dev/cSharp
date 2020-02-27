using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviews.Models
{
    [NotMapped]
    public class MovieList
    {
        public List<Movie> MovieLibrary {get;set;}
        public Movie MovieToAdd {get;set;}
    }
}