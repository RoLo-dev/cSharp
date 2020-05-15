using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieReviews.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MovieReviews.Controllers
{
    public class HomeController : Controller
    {
        private int? UserSession
        {
            get{ return HttpContext.Session.GetInt32("UserId"); }
            set{ HttpContext.Session.SetInt32("UserId", (int)value); }
        }
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("moviequest/register")]
        public IActionResult RegPage()
        {
            return View("Register");
        }
        [HttpPost("moviequest/register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Invalid credentials");
                    return View("Register");
                } else{
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    UserSession = newUser.UserId;
                    HttpContext.Session.SetString("Email", newUser.Email);
                    return RedirectToAction("Library");
                }
            }
            return View("Register");
        }

        [HttpGet("moviequest/login")]
        public IActionResult LogPage()
        {
            return View("Login");
        }

        [HttpPost("moviequest/login")]
        public IActionResult Login(Login user)
        {
            if(ModelState.IsValid)
            {
                User userExists = dbContext.Users.FirstOrDefault(u => u.Email == user.LogEmail);
                if(userExists == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid credentials");
                    return View("Login");
                }
                var Hasher = new PasswordHasher<Login>();
                var Result = Hasher.VerifyHashedPassword(user, userExists.Password, user.LogPassword);
                if(Result == 0)
                {
                    ModelState.AddModelError("LogPassword", "Invalid credentials");
                    return View("Login");
                } else{
                    UserSession = userExists.UserId;
                    HttpContext.Session.SetString("Email", user.LogEmail);
                    return RedirectToAction("Library");
                }
            }
            return View("Login");
        }

        [HttpGet("moviequest/library")]
        public IActionResult Library()
        {
            List<Movie> AllMovies = dbContext.Movies
                .Include(m => m.MovieReviews)
                .ToList();
            List<Review> AllReviews = dbContext.Reviews
                .OrderByDescending(r => r.CreatedAt)
                .Include(r => r.Creator)
                .ToList();
            MovieList moviesInDb = new MovieList();
            moviesInDb.MovieLibrary = AllMovies;
            return View(moviesInDb);
        }

        [HttpGet("moviequest/new/movie")]
        public IActionResult NewMoviePage()
        {
            return View("NewMovie");
        }

        [HttpPost("moviequest/new/movie")]
        public IActionResult NewMovie(MovieList newMovie)
        {
            if(UserSession == null)
            {
                return View("Login");
            } else{
                if(ModelState.IsValid)
                {
                    dbContext.Movies.Add(newMovie.MovieToAdd);
                    dbContext.SaveChanges();
                    return RedirectToAction("Library");
                } else{
                    List<Movie> AllMovies = dbContext.Movies
                        .Include(m => m.MovieReviews)
                        .ToList();
                    List<Review> AllReviews = dbContext.Reviews
                        .OrderByDescending(r => r.CreatedAt)
                        .Include(r => r.Creator)
                        .ToList();
                    MovieList moviesInDb = new MovieList();
                    moviesInDb.MovieLibrary = AllMovies;

                    MovieList reviewsInDb = new MovieList();
                    reviewsInDb.MovieReviews = AllReviews;
                    ViewBag.DisplayReviews = reviewsInDb;

                    ViewBag.hasError=true;
                    return View("Library", moviesInDb);
                }
            }
        }

        [HttpGet("moviequest/movie/details/{MovieId}")]
        public IActionResult MovieDetails(int MovieId)
        {
            Movie movieInfo = dbContext.Movies
                .Include(m => m.MovieReviews)
                .FirstOrDefault(m => m.MovieId == MovieId);
            MovieList a = new MovieList();
            List<Movie> AllMovies = dbContext.Movies
                .Include(m => m.MovieReviews)
                .ToList();
            a.MovieToAdd = movieInfo;
            a.MovieLibrary = AllMovies;
            return Json(movieInfo);
        }

        [HttpPost("moviequest/review/new")]
        public IActionResult NewReview(MovieList newReview)
        {
            if(ModelState.IsValid)
            {
                dbContext.Reviews.Add(newReview.ReviewToAdd);
                dbContext.SaveChanges();
                return RedirectToAction("Library");
            } else
            {
                List<Movie> AllMovies = dbContext.Movies
                    .Include(m => m.MovieReviews)
                    .ToList();
                List<Review> AllReviews = dbContext.Reviews
                    .Include(r => r.UserId)
                    .ToList();
                MovieList reviewsInDb = new MovieList();
                reviewsInDb.MovieReviews = AllReviews;
                ViewBag.reviewError = true;
                return View("Library", reviewsInDb);
            }
        }

        [HttpGet("moviequest/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
