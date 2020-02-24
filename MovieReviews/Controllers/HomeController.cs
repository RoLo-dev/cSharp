using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieReviews.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using MovieReviews.Models;

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


        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
