using Microsoft.EntityFrameworkCore;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
}

public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<YourDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddControllers();
    services.AddSwaggerGen();
    // Add other necessary services
}
