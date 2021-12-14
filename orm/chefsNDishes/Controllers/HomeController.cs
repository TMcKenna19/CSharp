﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefsNDishes.Controllers
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

        // **********
        // home route
        // **********
        public IActionResult Index()
        {   
            ViewBag.AllChefs = _context.Chefs.Include(c => c.MyDishes).ToList();
            return View();
        }

        //******************
        // Add a chef route 
        //******************
        [HttpGet("addChef")]
        public IActionResult AddChef()
        {
            return View();
        }


        //***************
        //save chef route
        //***************
        [HttpPost("saveChef")]
        public IActionResult saveChef (Chef newChef)
        {
           if(ModelState.IsValid)
           {    
               _context.Add(newChef); //<--adds to db
               _context.SaveChanges();//<--saves to db
               return RedirectToAction("Index");
           }else{
               return View("addChef");
           }
        } 

        // [HttpPost("saveChef")]
        // public IActionResult saveChef(Chef newChef, DateTime chefDob)
        // {
        //     if(DateTime.Now.Year - chefDob.Year < 18)
        //         {
        //             ModelState.AddModelError("Age", "Invalid Date, Must be at least 18!");
        //             return View("addChef");
        //         }

        //     if(ModelState.IsValid)
        //     {
        //         if(_context.Chef.Any(c => c.chefFName == newChef.FirstName && c.chefLName == newChef.chefLName))
        //         {

        //             ModelState.AddModelError("FirstName", "Chef Already Exists!");
                    
        //             return View("addChef");
        //         } 
        //         age = DateTime.Now.Year - chefDob.Year;
        //         newChef.Age = age;
        //         _context.Add(newChef);
        //         _context.SaveChanges();
        //         return RedirectToAction("Index");
        //     }

        //     return View("NewChef");
        // }

        //**************
        // dishes route
        //**************
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllDishes = _context.Dishes.Include(c => c.MyChef).ToList();
            return View();
        }

        //***************
        // new dish route
        //***************
        [HttpGet("dishesNew")]
        public IActionResult DishesNew()
        {
            ViewBag.AllChefs = _context.Chefs.Include(c => c.MyDishes).ToList();
            return View();
        }

        //****************
        // add dish route
        //****************
        [HttpPost("addDish")]
        public IActionResult addDish (Dish newDish)
        {
           if(ModelState.IsValid)
           {    
               _context.Add(newDish); //<--adds to db
               _context.SaveChanges();//<--saves to db
               return RedirectToAction("dishes");
           }else{
               return View("addDish");
           }
        }

        // ***************************//

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
