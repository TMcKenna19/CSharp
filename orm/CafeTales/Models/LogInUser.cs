using System;
using System.ComponentModel.DataAnnotations;

namespace CafeTales.Models
{
    public class LogInUser
    {
        [Required]
        [EmailAddress]
        public string LogInEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string LogInPassword {get;set;}
    }
}