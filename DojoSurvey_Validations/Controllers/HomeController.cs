using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey_Validations.Models;

namespace DojoSurvey_Validations.Controllers
{
    public class HomeController : Controller
    {   
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", user);
            } else{
                return View("Index");
            }
        }




        public IActionResult Result(User user)
        {
            return View("Result", user);
        }
        public IActionResult Privacy()
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
