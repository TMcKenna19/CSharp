using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class User
    {

        [Key]
        
        public int UserId {get; set;}

        [Required(ErrorMessage = "First name must have a name")]
        [MinLength(2,ErrorMessage = "First name must be at least two characters")]
        public string FirstName {get; set;}

        [Required(ErrorMessage = "Last name must have a name")]
        [MinLength(2,ErrorMessage = "Last name must be at least two characters")]
        public string LastName {get; set;}

        [Required(ErrorMessage = "Email must be a valid email")]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [MinLength(8,ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password {get; set;}

        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}

        public List<Rsvp> RsvpList {get; set;}
        public List<Wedding> WeddingsCreated {get;set;} 

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string confirm {get;set;}



    }


}