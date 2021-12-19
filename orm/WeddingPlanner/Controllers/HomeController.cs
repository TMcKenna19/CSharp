using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
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
            return View();
        }

        // **************
        // Register Route 
        // **************
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);  //Add newUser to database 
                _context.SaveChanges(); //Saves newUser to database

                return RedirectToAction("Dashboard");

            } else{
                return View("Index");
            }
            // register is working with success route commented out. 
        }

        // *******************
        // Login Route Process 
        // *******************
        [HttpPost("loginProcess")]
        public IActionResult Login(LogInUser logInUser)
        {
            if(ModelState.IsValid)
            {   
                User userinDb = _context.Users.FirstOrDefault(u => u.Email == logInUser.LogInEmail);
                if(userinDb == null){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("Index");
                }
                PasswordHasher<LogInUser> Hasher = new PasswordHasher<LogInUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logInUser, userinDb.Password, logInUser.LogInPassword);
                if(result == 0){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", userinDb.UserId); //<---
                return RedirectToAction("Dashboard"); //try ->"Index" //try->dashboard
            }  else {
                return View("Index"); //try -> Dashboard
            }
            
        }

        // **************
        // Success Route 
        // **************
        // [HttpGet("success")]
        // public IActionResult Success()
        // {   
            
        //     if(HttpContext.Session.GetInt32("UserId") == null)
        //     {
        //     return RedirectToAction("index");

        // } else{
        //     return View("Dashboard");
        //     } 
        // }

        // ***************
        // dashboard route
        // ***************
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }





        //xxxxxxxxxxxxxxxxxxxxxxxxxx//
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
