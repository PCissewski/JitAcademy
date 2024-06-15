using Microsoft.EntityFrameworkCore;

namespace WebApplication4;
public class ProductDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductDbContext(DbContextOptions options) : base(options) { }
}