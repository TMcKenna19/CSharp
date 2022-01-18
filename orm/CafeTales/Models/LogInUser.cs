using System;
using System.ComponentModel.DataAnnotations;

namespace CafeTales.Models
{
    public class LogInUser
    {
        [Required(ErrorMessage = "Please enter valid email")]
        [EmailAddress]
        public string LogInEmail {get;set;}

        [Required(ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string LogInPassword {get;set;}
    }
}