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

        [Required(ErrorMessage = "First name must have a name")]
        [MinLength(2,ErrorMessage = "First name must be at least two characters")]
        public string UserFirstName {get;set;}

        [Required(ErrorMessage = "Email must be a valid email")]
        [EmailAddress]
        public string UserEmail {get;set;}

        [Required]
        [MinLength(8,ErrorMessage = "Password must be at least 8 characters")]
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

