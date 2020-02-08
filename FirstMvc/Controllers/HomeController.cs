using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstMvc.Models;

namespace FirstMvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string someMessage = "Hello World";
            return View("Index", someMessage);
        }
        [HttpGet("/numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = {3,2,1992,10,25,1983,7};
            return View( numbers);
        }
        [HttpGet("/users")]
        public IActionResult Users()
        {
            User someUser = new User()
            {
                FirstName = "Long",
                LastName = "Tall Sally"
            };
            User secondUser = new User()
            {
                FirstName = "Billy",
                LastName = "Jean"
            };
            User thirdUser = new User()
            {
                FirstName = "Loose",
                LastName = "Moose"
            };
            
            List<User> viewUsers = new List<User>()
            {
                someUser, secondUser, thirdUser
            };
            return View(viewUsers);
        }
        [HttpGet("/user")]
        public IActionResult User()
        {
            User oneUser = new User()
            {
                FirstName = "Pan",
                LastName = "de Limon"
            };
            return View(oneUser);
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
