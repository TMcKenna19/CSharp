using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using loginReg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;



namespace loginReg.Controllers
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
                if(_context.Users.Any(u => u.email == newUser.email))
                {
                    ModelState.AddModelError("email", "Email already in use");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.password = Hasher.HashPassword(newUser, newUser.password);
                _context.Add(newUser);  //Add newUser to database 
                _context.SaveChanges(); //Saves newUser to database

                return RedirectToAction("Success");

            } else{
                return View("Index");
            }
        }

        // **************
        // Success Route 
        // **************
        [HttpGet("success")]
        public IActionResult Success()
        {   
            
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
            return RedirectToAction("login");

        } else{
            return View();
            } 
        }

        // *****************
        // Login Page Route  
        // *****************
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }


        // *******************
        // Login Route Process 
        // *******************
        [HttpPost("loginProcess")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {   
                User userinDb = _context.Users.FirstOrDefault(u => u.email == logUser.email);
                if(userinDb == null){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("login");
                }
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userinDb.password, logUser.password);
                if(result == 0){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("login");
                }
                HttpContext.Session.SetInt32("UserId", userinDb.UserId); //<---
                return RedirectToAction("Success");
            }  else {
                return View("login");
            }
            
        }

        //************
        //Logout Route
        //************
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login");
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
