using System;
using System.ComponentModel.DataAnnotations;

namespace chefsNDishes.Models
{

    public class Dish
    {
        [Key]

        public int dishId {get;set;}

        [Required(ErrorMessage = "Please add a dish name")]
        public string nameOfDish {get;set;}

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Calories must be more than 0")]
        public int numCals {get;set;
        }
        [Required(ErrorMessage = "Please add a description")]
        public string description {get;set;}

        [Required(ErrorMessage = "Please add a tastiness number")]
        public int tastiness {get;set;}

        //establishes a place for the foreign key 
        public int ChefId {get;set;}

        //we get a whole object reference
        public Chef MyChef {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;


    }
    
}