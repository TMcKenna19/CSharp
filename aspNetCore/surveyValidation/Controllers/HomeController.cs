using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using surveyValidation.Models;

namespace surveyValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // static string name = "";
        // static string dojoLocation = "";
        // static string favLang = "";
        // static string comment = "";

        static Student newStudent;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // *****************
        //   post request 

        [HttpPost("process")]
        public IActionResult Process(Student myStudent)
        {
            // name = uName;
            // dojoLocation = dLocation;
            // favLang = fLang;
            // comment = oComment;
            newStudent = myStudent;
            return RedirectToAction("Results");
        }

        [HttpGet("results")]
        public IActionResult Results()
        {
        //   ViewBag.uName = name;
        //   ViewBag.dLocation = dojoLocation;
        //   ViewBag.fLang = favLang;
        //   ViewBag.oComment = comment;
          return View(newStudent);  
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
