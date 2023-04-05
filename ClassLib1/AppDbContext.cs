using EFCoreDemo.ClassLib1.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCoreDemoServer;",
        x => x.MigrationsAssembly("ClassLib2"));
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Vehicle>? Vehicles { get; set; }
}