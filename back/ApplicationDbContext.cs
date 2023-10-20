using Microsoft.EntityFrameworkCore;
using CarBon.Models;
public class ApplicationDbContext : DbContext
{
    public DbSet<UserInfo> UserInfo { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Favourites> Favourites { get; set; } 
    public DbSet<UserLogin> UserLogin { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Order> Order { get; set; }

    private readonly IConfiguration _configuration;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Carbon"));
        }
    }
}