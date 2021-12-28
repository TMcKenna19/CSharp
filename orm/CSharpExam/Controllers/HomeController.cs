using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpExam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace CSharpExam.Controllers
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
                if(_context.Users.Any(u => u.UserEmail == newUser.UserEmail))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.UserPassword = Hasher.HashPassword(newUser, newUser.UserPassword);
                _context.Add(newUser);   
                _context.SaveChanges(); 

                return RedirectToAction("Dashboard");

            } else{
                return View("Index");
            }
             
        }

        // *******************
        // Login Route Process 
        // *******************
        [HttpPost("loginProcess")]
        public IActionResult Login(LogInUser logInUser)
        {
            if(ModelState.IsValid)
            {   
                User userinDb = _context.Users.FirstOrDefault(u => u.UserEmail == logInUser.LogInEmail);
                if(userinDb == null){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("Index");
                }
                PasswordHasher<LogInUser> Hasher = new PasswordHasher<LogInUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logInUser, userinDb.UserPassword, logInUser.LogInPassword);
                if(result == 0){
                    ModelState.AddModelError("Email","Log in info is incorrect");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", userinDb.UserId); 
                return RedirectToAction("Dashboard"); 
            }  else {
                return View("Index");
            }
            
        }

        // ***************
        // Dashboard Route
        // ***************
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.AllHobbies = _context.Hobbies.OrderBy(a => a.AllHobbies).ToList();
            return View();
        }

        //************
        //Logout Route
        //************
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        //******************
        //New Activity Route
        //******************
        [HttpGet("NewActivity")]
        public IActionResult NewActivity()
        {
            return View();
        }

        //********************
        //Save Activity Route
        //********************
        [HttpPost("SaveActivity")]
        public IActionResult saveActivity (Hobby newHobby)
        {
           if(ModelState.IsValid)
           {    newHobby.UserId = (int)HttpContext.Session.GetInt32("UserId");
               _context.Add(newHobby);
               _context.SaveChanges();
               return RedirectToAction("OneActivity");
           }else{
               return View("NewActivity");
           }
        } 

        //******************
        //One Activity Route
        //******************
        [HttpGet("OneActivity")]
        public IActionResult OneActivity()
        {
            return View();
        }


        //xxxxxxxxxxxxxxxxxxxxxxxxxxxx//
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
