using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {   
            ViewBag.AllDishes = _context.Dishes.OrderBy(d =>d.CreatedAt).ToList();
            return View();
        }

        //new dish route
        [HttpGet("newDish")]
        public IActionResult newDish()
        {
            return View();
        }

        //add dish route
        [HttpPost("addDish")]
        public IActionResult addDish (Dish newDish)
        {
           if(ModelState.IsValid)
           {    
               _context.Add(newDish); //<--adds to db
               _context.SaveChanges();//<--adds to db
               return RedirectToAction("Index");
           }else{
               return View("newDish");
           }
        }

        //show dish
        [HttpGet("showDish/{DishId}")]
        public IActionResult showDish(int DishId)
        {   
            
            Dish one = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            return View(one);

        }

        //edit dish
        [HttpGet("editDish/{DishId}")]
        public IActionResult editDish(int DishId)
        {
            Dish one = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            return View(one);
        }
        [HttpPost("updateDish/{DishId}")]
        public IActionResult updateDish(int DishId, Dish update)
        {   
            if(ModelState.IsValid)
            {
            Dish one = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);

            one.chefName = update.chefName;
            one.dishName = update.dishName;
            one.NumCals = update.NumCals;
            one.tasteNum = update.tasteNum;
            one.description = update.description;

            _context.SaveChanges(); 
            return RedirectToAction("Index");

            }else {
                return View("editDish", update);
            }

        }

        //delete dish
        [HttpGet("delete/{DishId}")]
        public IActionResult deleteDish(int DishId)
        {   
            Dish dishDelete = _context.Dishes.SingleOrDefault(d => d.DishId == DishId);
            _context.Dishes.Remove(dishDelete);
            _context.SaveChanges();
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
