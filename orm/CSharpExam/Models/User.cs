using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpExam.Models
{
    public class User
    {

        [Key]
        
        public int UserId {get; set;}

        [Required(ErrorMessage = "User Name must have a name")]
        [MinLength(2,ErrorMessage = "User Name must be at least two characters")]
        public string UserName {get; set;}

        [Required(ErrorMessage = "Email must be a valid email")]
        [EmailAddress]
        public string UserEmail {get; set;}

        [Required]
        [MinLength(8,ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string UserPassword {get; set;}

        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}

        public List<Attending> AttendingList {get; set;}
        public List<Hobby> HobbiesCreated {get;set;} 

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("UserPassword")]
        public string confirm {get;set;}



    }


}