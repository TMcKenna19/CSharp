using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {

        [Key]
        
        public int WeddingId {get; set;}

        // [Required(ErrorMessage = "Wedder One must have a name")]
        // [MinLength(2,ErrorMessage = "Wedder One name must be at least two characters")]
        public string WedderOne {get; set;}

        // [Required(ErrorMessage = "Wedder Two must have a name")]
        // [MinLength(2,ErrorMessage = "Wedder Two Name must be at least two characters")]
        public string WedderTwo {get; set;}

        // [Required(ErrorMessage = "Wedding must have a date")]
        public DateTime WeddingDate {get; set;}

        // [Required(ErrorMessage = "Wedding must have a date")]
        public string WeddingAddress {get; set;}

        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}

        public List<Rsvp> RsvpList {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}

    
    }


}