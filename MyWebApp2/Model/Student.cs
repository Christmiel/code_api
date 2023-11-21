using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyWebApp2.Model{
     [Table("Students")]
    public class Student {
        

        [Key]
        public long Id{get; set;}

        [Required , StringLength(25)]
        public string Name{get; set;}

        public int Score{get; set;}
    }
}