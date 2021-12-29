using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CafeTales.Models
{
    public class User
    {
        [Key]

        public int UserId {get;set;}

        public string UserFirstName {get;set;}

        public string UserEmail {get;set;}

        public string Password {get;set;}

        public List<Coffee> MyCoffees {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string confirm {get;set;}
    }
}