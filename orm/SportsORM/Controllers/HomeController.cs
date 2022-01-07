using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            //1. all womens league
            ViewBag.AllWomensLeague = _context.Leagues.Where(league => league.Name.Contains("Women")).ToList();
            

            //2. all leagues where sport is any type of hockey
            ViewBag.AllHockey = _context.Leagues
            .Where(league => league.Sport.Contains("Hockey"))
            .ToList();
            
            //3. all leagues where sport is something OTHER THAN football
            ViewBag.NotFootball = _context.Leagues
            .Where(league => !league.Sport.Contains("Football"))
            .ToList();

            //4.all leagues that call themselves "conferences"
            ViewBag.Conferences = _context.Leagues
            .Where(league => league.Name.Contains("Conference"))
            .ToList();


            //5. all leagues in the Atlantic region
            ViewBag.AtlanticReg = _context.Leagues
            .Where(league => league.Name.Contains("Atlantic"))
            .ToList();

            //6. all teams based in Dallas
            ViewBag.InDallas = _context.Teams
            .Where(league => league.Location.Contains("Dallas"))
            .ToList();


            //7.all teams named the Raptors
            ViewBag.Raptors = _context.Teams
            .Where(league => league.TeamName.Contains("Raptors"))
            .ToList();
            

            //8.all teams whose location includes "City"
            ViewBag.LocationCity = _context.Teams
            .Where(league => league.Location.Contains("City"))
            .ToList();

            // 9.all teams whose names begin with "T"
            ViewBag.BeginWithT = _context.Teams
            .Where(league => league.TeamName.Contains("T"))
            .ToList();
            
           //10. ...all teams, ordered alphabetically by location
           ViewBag.Alphabetical = _context.Teams
            .OrderBy(league => league.Location).ToList();
            

           //11. all teams, ordered by team name in reverse alphabetical order
           ViewBag.RevAlphabetical = _context.Teams
            .OrderByDescending(league => league.Location).ToList();

           //12. every player with last name "Cooper"
           ViewBag.LnameCooper = _context.Players
            .Where(league => league.LastName.Contains("Cooper"))
            .ToList();
            
           
           //13. every player with first name "Joshua"
           ViewBag.FnameJoshua = _context.Players
            .Where(league => league.FirstName.Contains("Joshua"))
            .ToList();
           
           
           //14. every player with last name "Cooper" EXCEPT those with "Joshua" as the first name
           ViewBag.NotJosh = _context.Players
            .Where(league => !league.FirstName.Contains("Joshua") && league.LastName.Contains("Cooper"))
            .ToList();
           

           //15. all players with first name "Alexander" OR first name "Wyatt"
           ViewBag.ThisThat = _context.Players
            .Where(league => league.FirstName.Contains("Alexander") || league.FirstName.Contains("Wyatt"))
            .ToList();

           return View();

        }

        //=======================
        //level 2 
        //=======================
        [HttpGet("level_2")]
        public IActionResult Level2()
        {
           return View();
        }
        
        

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}