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

        public string CupOfCoffeeName {get;set;}

        public string CupOfRoasterName {get;set;}

        public string CupOfRoastType {get;set;}

        public string CupOfDescription {get;set;}

        public string H2oTemp {get;set;}

        public string BrewMethod {get;set;}

        public string GrindSize {get;set;}

        public string Rating {get;set;}

        public int UserId {get;set;}

        public User MyUser {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}