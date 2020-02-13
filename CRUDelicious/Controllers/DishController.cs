using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace CRUDelicious.Controllers
{
    public class DishController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public DishController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes
            .OrderByDescending(d => d.CreatedAt)
            .Take(5)
            .ToList();
            return View(AllDishes);
        }

        [HttpGet("new")]
        public IActionResult AddDish()
        {
            return View();
        }

        [HttpPost("newDish")]
        public IActionResult AddNewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("AddDish");
            }
        }

        [HttpGet]
        [Route("{dishid}")]
        public IActionResult DishView(int dishid)
        {
            Dish oneDish = dbContext.Dishes.Single(d => d.DishId == dishid);
            return View(oneDish);
        }

        [HttpPost("deletedish")]
        public IActionResult DeleteDish(int dishid)
        {
            Dish oneDish = dbContext.Dishes.Single(d => d.DishId == dishid);
            dbContext.Dishes.Remove(oneDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{dishid}")]
        public IActionResult EditDishView(int dishid)
        {
            Dish oneDish = dbContext.Dishes.Single(d => d.DishId == dishid);
            return View(oneDish);
        }

        [HttpPost("editDish/{dishid}")]
        public IActionResult EditDish(Dish retrieveDish, int dishid)
        {
            if(ModelState.IsValid)
            {
                Dish dishToUpdate = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishid);
                dishToUpdate.Name = retrieveDish.Name;
                dishToUpdate.Chef = retrieveDish.Chef;
                dishToUpdate.Calories = retrieveDish.Calories;
                dishToUpdate.Tastiness = retrieveDish.Tastiness;
                dishToUpdate.Description = retrieveDish.Description;
                dbContext.SaveChanges();
                return RedirectToAction("DishView", "Dish", new{dishid});
            } else{
                return View("EditDish", retrieveDish);
            }
        }
    }
}