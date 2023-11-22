using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace CatalogueApp.Models 
{
    [Table("CATEGORIES")]
    public class Category
    {
        [Key]
        public int Cat_Id { get; set; }
        [Required]
        public string Cat_Name { get; set; }

        [JsonIgnore]
       public virtual ICollection<Product> Products {get; set;}



    }
}