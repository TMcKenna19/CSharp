using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharpExam.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId {get; set;}

        [Required(ErrorMessage = "Hobby must have a Title")]
        public string HobbyTitle {get; set;}

        [Required(ErrorMessage = "Hobby must have a date")]
        public DateTime HobbyDate {get; set;}

        public int HobbyDuration {get; set;}

        public string HobbyDurationTime {get; set;}

        public string Description {get; set;}

        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}

        public List<Attending> AttendingList {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
    }
}