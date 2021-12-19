using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
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