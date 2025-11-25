using eCommerce.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
