using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entities;
namespace SimpleBookCatalog.Infracture.Context
{
    public class SimpleBookCatDbContext:DbContext
    {
        public SimpleBookCatDbContext(DbContextOptions<SimpleBookCatDbContext> options):base(options) 
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
