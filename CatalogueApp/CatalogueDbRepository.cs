using Microsoft.EntityFrameworkCore;
namespace CatalogueApp

{
    public class CatalogueDbRepository : DbContext
{
    public CatalogueDbRepository(DbContextOptions options) : base (options)
    {

    }
}
}