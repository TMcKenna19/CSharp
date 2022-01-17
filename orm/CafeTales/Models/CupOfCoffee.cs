using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeTales.Models
{
    public class CupOfCoffee
    {
        [Key]

        public int CupOfCoffeeId {get;set;}

        [Required(ErrorMessage = "Please add a Coffee Name")]
        public string CupOfCoffeeName {get;set;}

        [Required(ErrorMessage = "Please add a Roster Name")]
        public string CupOfRoasterName {get;set;}

        [Required(ErrorMessage = "Please add a Roast type")]
        public string CupOfRoastType {get;set;} 

        public string CupOfDescription {get;set;}

        [Required(ErrorMessage = "Please add Water Temperature")]
        public string H2oTemp {get;set;}
        
        [Required(ErrorMessage = "Please add a Brew Method")]
        public string BrewMethod {get;set;}
        
        [Required(ErrorMessage = "Please add a Grind Size")]
        public string GrindSize {get;set;}

        [Required(ErrorMessage = "Please add a Rating")]
        public string Rating {get;set;}

        public int UserId {get;set;}

        public User MyUser {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}