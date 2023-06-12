using Microsoft.EntityFrameworkCore;
using CarBon.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<UserInfo> UserInfo { get; set; } = null!;
    public DbSet<Cart> Carts { get; set; } = null!;
    public DbSet<Authorization> Authorization { get; set; } = null!;
    public DbSet<UserLogin> UserLogin { get; set; } = null!;
    public DbSet<Product> Product { get; set; } = null!;
    public DbSet<Order> Order { get; set; } = null!;


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=u;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}