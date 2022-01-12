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
        
        [Required(ErrorMessage = "Please add a coffee name")]
        public string CoffeeName {get;set;}

        [Required(ErrorMessage = "Please add a roster name")]
        public string RoasterName {get;set;}

        [Required(ErrorMessage = "Please add a Roast type")]
        public string RoastType {get;set;}

        public string Description {get;set;}

        public int UserId {get;set;}

        public User MyUser {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}