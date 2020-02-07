using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Date = CurrentTime.ToString("MMMM dd, yyyy");
            ViewBag.Time = CurrentTime.ToString("hh:mm tt");
            return View();
        }
    }
}