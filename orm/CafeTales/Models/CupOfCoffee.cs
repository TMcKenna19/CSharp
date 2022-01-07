using System;
using System.ComponentModel.DataAnnotations;

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

        public int UserId {get;set;}

        public User MyUser {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}