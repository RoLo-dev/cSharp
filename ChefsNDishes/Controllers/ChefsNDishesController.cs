using Microsoft.EntityFrameworkCore;
using ChefsNDishes.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace ChefsNDishes.Controllers
{
    public class ChefsNDishes : Controller
    {
        private Context dbContext;
        // here we can "inject" our context service into the constructor
        public ChefsNDishes(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult AllChefs()
        {
            List<Chef> AllChefsDishes = dbContext.Chefs
            .Include(q => q.CreatedDishes)
            .ToList();
            return View(AllChefsDishes);
        }

        [HttpGet("dishes")]
        public IActionResult AllDishes()
        {
            List<Dish> DishesWChefs = dbContext.Dishes
            .Include(q => q.Creator)
            .ToList();
            return View(DishesWChefs);
        }

        [HttpGet("chef/new")]
        public IActionResult NewChefPage()
        {
            return View("NewChef");
        }

        [HttpPost("chef/new")]
        public IActionResult NewChef(Chef newChef)
        {
            Console.WriteLine("NewChef");
            if(ModelState.IsValid)
            {
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("AllChefs");
            } else{
                if(newChef.DateOfBirth.Year == 1){
                    if(ModelState.ContainsKey("DateOfBirth") == true){
                        ModelState["DateOfBirth"].Errors.Clear();
                    }
                    ModelState.AddModelError("DateOfBirth", "Invalid date");
                }
                return View("NewChef");
            }
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDishPage()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;
            return View("NewDish");
        }

        [HttpPost("dishes/new")]
        public IActionResult NewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                Chef chefInQuestion = dbContext.Chefs.FirstOrDefault(q => q.ChefId == newDish.ChefId);
                newDish.Creator = chefInQuestion;
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("AllDishes");
            } else{
                return View("NewDish");
            }
        }
    }
}