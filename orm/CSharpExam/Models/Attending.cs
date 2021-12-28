using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpExam.Models
{
    public class Attending
    {

        [Key]
        
        public int AttendingId {get; set;}

        public int UserId {get; set;}

        public int HobbyId {get; set;}

        public User User {get; set;}
        public Hobby Hobby {get; set;}


    
    }


}