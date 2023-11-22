using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CatalogueApp.Models ;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CatalogueApp.Controllers
{
    [Route("/api/categories")]
    public class  CategoryRestController : Controller
    {
        public CatalogueDbRepository catalogueRepository {get; set;}

        public CategoryRestController(CatalogueDbRepository repository)
        {
                this.catalogueRepository = repository;
        }

        [HttpGet]

        public IEnumerable<Category> ListCategories()
        {
            return catalogueRepository.Categories;
        }

         [HttpGet("{Id}")]

        public Category OneCat(int Id)
        {
           
            return  catalogueRepository.Categories.FirstOrDefault(c => c.Cat_Id == Id) ;
        }

         [HttpGet("{Id}/products")]

        public IEnumerable<Product> products(int Id)
        {
            Category category = catalogueRepository.Categories.Include(c=>c.Products)
            .FirstOrDefault(c => c.Cat_Id == Id) ;
           
            return  category.Products ;
        }

         [HttpPost]

        public Category CreateCategories([FromBody] Category category )
        {
           catalogueRepository.Categories.Add(category);
           catalogueRepository.SaveChanges();
            return category;
        }

         [HttpPut("{Id}")]

        public Category UpdateCategories( int Id,  [FromBody] Category category )
        {
            category.Cat_Id = Id;
           catalogueRepository.Categories.Update(category);
           catalogueRepository.SaveChanges();
            return category;
        }

           [HttpDelete("{Id}")]

        public void DeleteCat( int Id )
        {
           Category category = catalogueRepository.Categories.FirstOrDefault(c => c.Cat_Id == Id) ;
           catalogueRepository.Remove(category);
           catalogueRepository.SaveChanges();
           
        }
    }
}