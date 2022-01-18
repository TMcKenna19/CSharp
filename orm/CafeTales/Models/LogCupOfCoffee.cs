using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeTales.Models
{
    public class LogCupOfCoffee
    {
        [Key]

        public int CupOfCoffeeId {get;set;}

        [Required(ErrorMessage = "Please add a Coffee Name")]
        public string LogCupOfCoffeeName {get;set;}

        [Required(ErrorMessage = "Please add a Roster Name")]
        public string LogCupOfRoasterName {get;set;}

        [Required(ErrorMessage = "Please add a Roast type")]
        public string LogCupOfRoastType {get;set;} 

        public string LogCupOfDescription {get;set;}

        [Required(ErrorMessage = "Please add Water Temperature")]
        public string LogH2oTemp {get;set;}
        
        [Required(ErrorMessage = "Please add a Brew Method")]
        public string LogBrewMethod {get;set;}
        
        [Required(ErrorMessage = "Please add a Grind Size")]
        public string LogGrindSize {get;set;}

        [Required(ErrorMessage = "Please add a Rating")]
        public string LogRating {get;set;}

        public int UserId {get;set;}

        public User MyUser {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}