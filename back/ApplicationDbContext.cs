using Microsoft.EntityFrameworkCore;
//using ReactApi.Data;
using CarBon.Models;
//namespace ReactApi.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> UserLogin { get; set; } = null!;
   

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=u;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}