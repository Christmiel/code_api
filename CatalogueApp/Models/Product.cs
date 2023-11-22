using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CatalogueApp.Models;

namespace CatalogueApp.Models{
    [Table("Products")]
    public class Product{
        [Key]
        public int Prod_Id { get; set; }

        public string Prod_Name { get; set; }

        public int Prod_Price { get; set; }

        public int Cat_Id {get; set;}

        [ForeignKey("Cat_Id")]

        public virtual Category Category {get; set;}
    }
}