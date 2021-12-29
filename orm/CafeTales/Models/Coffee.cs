using System;
using System.ComponentModel.DataAnnotations;

namespace CafeTales.Models
{
    public class Coffee
    {
        [Key]

        public int CoffeeId {get;set;}

        public string CoffeeName {get;set;}

        public string RoasterName {get;set;}

        public string RoastType {get;set;}

        public string Description {get;set;}

        public int UserId {get;set;}

        public User MyUser {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}