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

        
        static Student newStudent;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost("process")]
        public IActionResult Process(Student myStudent)
        {
            if(ModelState.IsValid)
            {
                newStudent = myStudent;
                return RedirectToAction("Results");
            }else{
                return View("Index");
            }
        }

        [HttpGet("results")]
        public IActionResult Results()
        {
        
          return View(newStudent);  
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
