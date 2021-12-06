using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using passwordGen.Models;
using Microsoft.AspNetCore.Http;

namespace passwordGen.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private string PassCode(int size)
        {
           Random rand = new Random();
        //    string w/num and letters
           string CharsPassCode = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
        //    populate string
           string NewPassCode = "";
        //    pass random string(PW), into empty string 
        //      idturate num/letters to generate new PW
           for(int i = 0; i < size; i++)
           {
              NewPassCode += (CharsPassCode [rand.Next(CharsPassCode.Length)]);
           }
           
            return NewPassCode;
        }

        [HttpGet("")]
        public IActionResult Index()
        {   // show route 
            // use session
            // HttpContext.Session.SetString("NewPass", "Click Generate");
            // count # of passCode
            // HttpContext.Session.SetInt32("count", 0); 
            // use session to get passCode 
           
            
            if (HttpContext.Session.GetInt32("count") == null)
            {
                HttpContext.Session.SetInt32("count", 0); // count = 0
            }
            if (HttpContext.Session.GetString("NewPass") == null)
            {
                HttpContext.Session.SetString("NewPass", "Click Generate");
            }

            ViewBag.NewPass = HttpContext.Session.GetString("NewPass");
            ViewBag.Count = HttpContext.Session.GetInt32("count");
            
           return View();
        }

        [HttpGet("results")]
        public IActionResult Results()
        {   //button takes us to index shows results of passCode ---> holds logic of session 
            int? count = HttpContext.Session.GetInt32("count");
            count++;
            HttpContext.Session.SetInt32("count",(int)count);
            HttpContext.Session.SetString("NewPass",PassCode(14));
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

