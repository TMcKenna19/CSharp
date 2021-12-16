using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace productsCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get; set;}

        [Required]
        public string prodName {get; set;}

        [Required]
        public string prodDescription {get; set;}

        [Required]
        public double prodPrice {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public List<Association> AssociationsList {get; set;}

    }
}