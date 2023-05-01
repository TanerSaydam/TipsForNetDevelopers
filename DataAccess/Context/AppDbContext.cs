using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public sealed class AppDbContext : DbContext
{   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=DESKTOP-3BJ5GK9;Initial Catalog=TipsForNetDevelopersDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");               
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ErrorLog> ErrorLogs { get; set; }
    public DbSet<PerformanceLog> PerformanceLogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<HealthCheckResult> HealthCheckResults { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {        
        modelBuilder.Entity<Product>()
            .HasIndex(e=> e.Name)
            .IsUnique(); 
    }
}
