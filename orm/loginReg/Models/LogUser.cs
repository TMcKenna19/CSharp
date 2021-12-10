using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace loginReg.Models
{
    public class LogUser 
    {
       
        [Required]
        [EmailAddress]
        public string email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string password {get;set;}

    }
}