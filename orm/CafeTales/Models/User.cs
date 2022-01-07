using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeTales.Models
{
    public class User
    {
        [Key]

        public int UserId {get;set;}

        public string UserFirstName {get;set;}

        public string UserEmail {get;set;}

        [DataType(DataType.Password)]
        public string Password {get;set;}

        public List<Coffee> MyCoffees {get;set;}
        public List<CupOfCoffee> MyCupOfCoffees {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string confirm {get;set;}
    }
}

