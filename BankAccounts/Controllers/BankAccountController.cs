using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using BankAccounts.Models;

namespace BankAccounts.Controllers
{
    public class BankAccountController : Controller
    {
        private Context dbContext;

        public BankAccountController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(q => q.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is taken");
                    return View("Register");
                } else{
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();

                    int uid = newUser.UserId;
                    HttpContext.Session.SetInt32("uid", uid);

                    return RedirectToAction("Account");
                }
            } else{
                return View("Register");
            }
        }

        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View("Login");
        }

        [HttpPost("login")]
        public IActionResult Login(UserLogin currentUser)
        {
            if(ModelState.IsValid)
            {
                var userInDB = dbContext.Users.FirstOrDefault(q => q.Email == currentUser.LogEmail);
                if(userInDB == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid email");
                    return View("Login");
                }
                var hasher = new PasswordHasher<UserLogin>();
                var result = hasher.VerifyHashedPassword(currentUser, userInDB.Password, currentUser.LogPassword);

                if(result == 0)
                {
                    ModelState.AddModelError("LogPassword", "Invalid password");
                    return View("Login");
                }
                int uid = userInDB.UserId;
                HttpContext.Session.SetInt32("uid", uid);

                return RedirectToAction("Account");
            } else{
                return View("Login");
            }
        }

        [HttpGet("account")]
        public IActionResult Account()
        {
            int? uid = HttpContext.Session.GetInt32("uid");
            if(uid == null)
            {
                return RedirectToAction("Register");
            } else{
                var retrievedUser = dbContext.Users.Include(u => u.UserTransactions).OrderBy(q => q.CreatedAt).FirstOrDefault(q => q.UserId == uid);
                ViewBag.retrievedUser = retrievedUser;
                // List<Transaction> UsersTrans = dbContext.Transactions
                // .Where(t => t.UserId == uid)
                // .OrderByDescending(t => t.CreatedAt)
                // .ToList();

                decimal sum = dbContext.Transactions
                .Where(t => t.UserId == uid)
                .Sum(t => t.Amount);
                ViewBag.Total = sum;
                return View("Account");
            }
        }

        [HttpPost("account/new")]
        public IActionResult NewTrans(Transaction transaction)
        {
            if(ModelState.IsValid)
            {
                int? uid = HttpContext.Session.GetInt32("uid");
                var retrievedUser = dbContext.Users.FirstOrDefault(q => q.UserId == uid);

                transaction.UserId = retrievedUser.UserId;

                dbContext.Transactions.Add(transaction);
                dbContext.SaveChanges();

                if(transaction.Amount < 0)
                {
                    ModelState.AddModelError("Amount", "There is not enough funds");
                    return RedirectToAction("Account");
                }
                return RedirectToAction("Account");
            } else {
                return View("Account");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }
    }
}