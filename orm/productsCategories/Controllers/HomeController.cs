using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using productsCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace productsCategories.Controllers
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
            ViewBag.allProducts = _context.Products.OrderBy(a => a.prodName).ToList();
            return View();
        }

        //***************
        // save product
        //***************
        [HttpPost("addProduct")]
        public IActionResult addProduct (Product newProduct)
        {
           if(ModelState.IsValid)
           {    
               _context.Add(newProduct); //<--adds to db
               _context.SaveChanges();//<--saves to db
               return RedirectToAction("Index");
           }else{
               ViewBag.allProducts = _context.Products.OrderBy(a => a.prodName).ToList();
               return View("Index");
           }
        } 

        //***************
        // category route 
        //***************
        [HttpGet("categories")]
        public IActionResult Categories()
        {   
            ViewBag.allCategories = _context.Categories.OrderBy(c => c.catName).ToList();
            return View();
        }

        //***************
        // save category
        //***************
        [HttpPost("addCategory")]
        public IActionResult addCategory (Category newCategory)
        {
           if(ModelState.IsValid)
           {    
               _context.Add(newCategory); //<--adds to db
               _context.SaveChanges();//<--saves to db
               return RedirectToAction("categories");
           }else{
               ViewBag.allCategories = _context.Categories.OrderBy(c => c.catName).ToList();
               return View("categories");
           }
        } 

        //*************
        // one product
        //*************
        [HttpGet("product/{prodId}")]
        public IActionResult oneProduct(int prodId)
        {   
            Product one = _context.Products.Include(f => f.AssociationsList).ThenInclude(g => g.Category).FirstOrDefault(p => p.ProductId == prodId);
            ViewBag.allCategories = _context.Categories.OrderBy(c => c.catName).ToList();
            return View(one);
        }
        

        // ***************
        //  addProdToCat
        // ***************
        [HttpPost("/product/addProdToCat")]
        public IActionResult addProdToCat(Association newProdToCat)
        {   
            _context.Add(newProdToCat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //**************
        // one category
        //**************
        [HttpGet("category/{categoryId}")]
        public IActionResult oneCategory(int categoryId)
        {   
            Category one = _context.Categories.Include(f => f.AssociationsList).ThenInclude(g => g.Product).FirstOrDefault(p => p.CategoryId == categoryId);
            ViewBag.allProducts = _context.Products.OrderBy(p => p.prodName).ToList();
            return View(one);
        }

        // *************
        // addCatToProd
        // *************



        








        
        //xxxxxxxxxxxxxxxxxxxxxxxxxx//
        //        STOP
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
