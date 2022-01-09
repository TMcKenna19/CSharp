using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CafeTales.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace CafeTales.Controllers
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

        //========================//
        //    LogReg Route
        //=======================//
        [HttpGet("RegLog")]
        public IActionResult RegLog()
        {
            return View();
        }

        //========================//
        //    Register Route
        //=======================//
        
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.UserEmail == newUser.UserEmail))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("RegLog");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);  //Add newUser to database 
                _context.SaveChanges(); //Saves newUser to database

                return RedirectToAction("Journal");

            } else{
                return View("RegLog");
            }
             
        }     
             //Reg route working and saves user in db

             
        //========================//
        //     Login Route
        //=======================//
        [HttpPost("LoginProcess")]
        public IActionResult Login(LogInUser logInUser)
        {
            if(ModelState.IsValid)
            {   
                User userinDb = _context.Users.FirstOrDefault(u => u.UserEmail == logInUser.LogInEmail);
                if(userinDb == null){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("RegLog");
                }
                PasswordHasher<LogInUser> Hasher = new PasswordHasher<LogInUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logInUser, userinDb.Password, logInUser.LogInPassword);
                if(result == 0){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("RegLog");
                }
                HttpContext.Session.SetInt32("UserId", userinDb.UserId); 
                return RedirectToAction("Journal"); 
            }  else {
                return View("RegLog");
            }
            
        }        //Login working with session 

        //=====================
        //   Logout Route
        //=====================
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        //========================//
        //    Journal Route
        //=======================//
        [HttpGet("Journal")]
        public IActionResult Journal()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
            return RedirectToAction("RegLog");

        } else{
            return View();
            } 
        }

        

        //========================//
        //    Shop Route
        //=======================//
        [HttpGet("Shop")]
        public IActionResult Shop()
        {
            return View();
        }


        //========================//
        //    Education Route
        //=======================//
        [HttpGet("Education")]
        public IActionResult Education()
        {
            return View();
        }


        




        //=============================//
        //      xxxxxxxxxxxxxx
        //=============================//
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
