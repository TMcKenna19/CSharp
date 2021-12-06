using System;
using System.ComponentModel.DataAnnotations; //This is for validations 

namespace surveyValidation.Models
{
    public class Student
    {   
        [Required(ErrorMessage = "Student must have a name")]
        [MinLength(2,ErrorMessage = "Student name must be at least two characters")]
        public string name {get;set;}
        [Required]
        public string dojoLocation {get;set;}
        [Required]
        public string favLang {get;set;}
        [Required]
        public string comment {get;set;}
    }
}