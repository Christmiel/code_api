using Microsoft.EntityFrameworkCore;
using CatalogueApp.Models;

namespace CatalogueApp

{
    public class CatalogueDbRepository : DbContext
{
    public DbSet<Category> Categories {get; set;}

    public DbSet <Product> Products{ get; set;}

    public CatalogueDbRepository(DbContextOptions options) : base (options)
    {

    }
}
}