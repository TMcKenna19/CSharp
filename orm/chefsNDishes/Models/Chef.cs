using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace chefsNDishes.Models
{

    public class Chef
    {
        [Key]

        public int ChefId {get;set;}

        [Required(ErrorMessage = "First name must have a name")]
        public string chefFName {get;set;}

        [Required(ErrorMessage = "Last name must have a name")]
        public string chefLName {get;set;}

        // [Required(ErrorMessage = "Chef must have a date of birth")]
        public DateTime chefDob {get;set;}

        //set up a list of students
        public List<Dish> MyDishes {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;


    }
    
}