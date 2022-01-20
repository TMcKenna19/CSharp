using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeTales.Models
{
    public class Coffee
    {
        [Key]

        public int CoffeeId {get;set;}
        
        [Required(ErrorMessage = "Please add a Coffee Name")]
        public string CoffeeName {get;set;}

        [Required(ErrorMessage = "Please add a Roster Name")]
        public string RoasterName {get;set;}

        [Required(ErrorMessage = "Please add a Roast Type")]
        public string RoastType {get;set;}

        public string Description {get;set;}

        public int UserId {get;set;}

        public User MyUser {get;set;}

        public List<Coffee> MyCoffees {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}

//update db, added line 29