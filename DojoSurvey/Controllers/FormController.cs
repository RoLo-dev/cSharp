using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class FormController : Controller
    {
        [HttpGet("")]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Result(string FullName, string Location, string Language, string Comment)
        {
            ViewBag.FullName = FullName;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View();
        }
    }
}