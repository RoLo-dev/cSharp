using System;
using Microsoft.EntityFrameworkCore;
using LogReg.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LogReg.Controllers
{
    public class UserController : Controller
    {
        private Context dbContext;

        public UserController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(q => q.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already being used");
                    return View("Index");
                } else{
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    // User NewUser = new User
                    // {
                    //     FirstName = newUser.FirstName,
                    //     LastName = newUser.LastName,
                    //     Email = newUser.Email,
                    //     Password = Hasher.HashPassword(newUser, newUser.Password)
                    // };
                    // dbContext.Users.Add(NewUser);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();

                    int uid = newUser.UserId;
                    HttpContext.Session.SetInt32("uid", uid);

                    return RedirectToAction("Success");
                }
            } else{
                return View("Index");
            }
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult LogInUser(Login currentUser)
        {
            var userInDb = dbContext.Users.FirstOrDefault(q => q.Email == currentUser.LEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("LEmail", "Invalid credentials");
                return View("Login");
            }
            var hasher = new PasswordHasher<Login>();

            var result = hasher.VerifyHashedPassword(currentUser, userInDb.Password, currentUser.LPassword);

            if(result == 0)
            {
                ModelState.AddModelError("LPassword", "Invalid Credentials");
                return View("Login");
            }
            int uid = userInDb.UserId;
            HttpContext.Session.SetInt32("uid", uid);

            return RedirectToAction("Success");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            int? userID = HttpContext.Session.GetInt32("uid");
            if(userID == null)
            {
                return RedirectToAction("Index");
            } else{
                User getUser = dbContext.Users.FirstOrDefault(q => q.UserId == userID);
                return View(getUser);
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}