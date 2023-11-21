using Microsoft.EntityFrameworkCore;
using MyWebApp2.Model;


namespace MyWebApp2
{
    public class MyDbContext: DbContext {

        public DbSet<Student> Students{get; set;}
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}