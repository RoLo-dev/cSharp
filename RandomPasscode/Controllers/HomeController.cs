using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("random_passcode")]
        public IActionResult RandomPasscode()
        {
            int? Count = HttpContext.Session.GetInt32("Count");
            Count = (Count == null) ? 0 : Count;
            Count++;
            HttpContext.Session.SetInt32("Count", (int)Count);
            ViewBag.Count = Count;

            Random passcode = new Random();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string Code = "";
            for(int i = 0; i <= 15; i++)
            {
                int char_num = passcode.Next(0, letters.Length - 1);
                Code += letters[char_num];
            }
            HttpContext.Session.SetString("Code", Code);
            ViewBag.Code = Code;
            return View();
        }
        [HttpGet("Reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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
