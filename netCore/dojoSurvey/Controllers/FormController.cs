using System;
using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey.Controllers
{
   public class FormController : Controller
   {   
       [HttpGet]
       [Route("")]
       public IActionResult Index()
       {
           return View("Index");
       }
       [HttpPost]
       [Route("process")]

       public IActionResult Process(string name,string dojoLocation, string favLang, string comment)
       {    
        
           ViewBag.Name = name;
           ViewBag.Location = dojoLocation;
           ViewBag.Lang = favLang;
           ViewBag.Comment = comment;

           return View("Result");
       }
   } 
}