using System;
using System.ComponentModel.DataAnnotations;


namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required(ErrorMessage = "Chef must have a name")]
        public string chefName {get;set;}

        [Required(ErrorMessage = "Dish must have a name")]
        public string dishName {get;set;}

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Calories must be more than 0")]
        public int NumCals {get;set;}

        [Required(ErrorMessage = "Please add a tastiness number")]
        public int tasteNum {get;set;}

        [Required(ErrorMessage = "Please add a description")]
        public string description {get;set;}

        
        public DateTime CreatedAt {get;set;} = DateTime.Now;        
        public DateTime UpdatedAt {get;set;} = DateTime.Now;


    }
}