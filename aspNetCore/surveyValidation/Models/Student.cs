using System;
using System.ComponentModel.DataAnnotations;

namespace surveyValidation.Models
{
    public class Student
    {   
        [Required]
        public string name {get;set;}
        [Required]
        public string dojoLocation {get;set;}
        [Required]
        public string favLang {get;set;}
        [Required]
        public string comment {get;set;}
    }
}