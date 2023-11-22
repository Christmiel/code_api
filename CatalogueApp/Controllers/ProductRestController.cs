using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CatalogueApp.Models ;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CatalogueApp.Controllers
{
    [Route("/api/products")]
    public class  ProductRestController : Controller
    {
        public CatalogueDbRepository catalogueRepository {get; set;}

        public ProductRestController(CatalogueDbRepository repository)
        {
                this.catalogueRepository = repository;
        }

        [HttpGet]

        public IEnumerable<Product> findAll()
        {
            return catalogueRepository.Products.Include(p=>p.Category);
        }


        // creer une pagination
        [HttpGet("Paginate")]

        public IEnumerable<Product> page(int page=0, int size=1)
        {
            int skipvalue = (page-1)*size;
            return catalogueRepository
            .Products
            .Include(p=>p.Category)
            .Skip(skipvalue)
            .Take(size);
        }


         [HttpGet("serch")]

        public IEnumerable<Product> serch( string kw)
        {
            return
             catalogueRepository
             .Products
             .Include(p=>p.Category)
             .Where(p=>p.Prod_Name.Contains(kw));
        }


         [HttpGet("{Id}")]

        public Product OneProduct(int Id)
        {
           
            return  catalogueRepository.Products.Include(p=>p.Category)
            .FirstOrDefault(p => p.Prod_Id == Id) ;
        }

         [HttpPost]

        public Product CreateProduct([FromBody] Product product )
        {
           catalogueRepository.Products.Add(product);
           catalogueRepository.SaveChanges();
            return product;
        }

         [HttpPut("{Id}")]

        public Product UpdateProduct( int Id,  [FromBody] Product product )
        {
            product.Prod_Id = Id;
           catalogueRepository.Products.Update(product);
           catalogueRepository.SaveChanges();
            return product;
        }

           [HttpDelete("{Id}")]

        public void Delete( int Id )
        {
           Product product = catalogueRepository.Products.FirstOrDefault(p => p.Prod_Id == Id) ;
           catalogueRepository.Remove(product);
           catalogueRepository.SaveChanges();
           
        }
    }
}