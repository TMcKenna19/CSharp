using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginReg.Models
{
    public class User 
    {
        //Never forget Key
        [Key]

        public int UserId {get;set;}

        [Required(ErrorMessage = "First name must have a name")]
        [MinLength(2,ErrorMessage = "First name must be at least two characters")]
        public string firstName {get;set;}

        [Required(ErrorMessage = "Last name must have a name")]
        [MinLength(2,ErrorMessage = "Last name must be at least two characters")]
        public string lastName {get;set;}

        [Required(ErrorMessage = "Email must be a valid email")]
        [EmailAddress]
        public string email {get;set;}

        [Required]
        [MinLength(8,ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string password {get;set;}


        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}

        //Below, Things I do not want to save to the database 
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirm {get;set;}

    }
}


//data flow 
// Model [x]
// Form [x]
// Post []
// Save []
// Retrieve []
// Render []
//