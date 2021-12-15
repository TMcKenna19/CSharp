using System;
using System.ComponentModel.DataAnnotations;

namespace productsCategories.Models
{
    public class Associations
    {
        [Key]

        public int AssociationsId {get; set;}

        public int ProdId {get; set;}

        public int CatId {get; set;}

        public Category Category {get; set;}

        public Product Product {get; set;}

    }
}