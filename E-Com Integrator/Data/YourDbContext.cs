using Microsoft.EntityFrameworkCore;
using EComIntegrator.Models;

namespace EComIntegrator.Data
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
