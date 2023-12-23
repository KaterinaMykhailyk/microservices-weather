using Microsoft.EntityFrameworkCore;
using CloudWeather.Temperature.Entities;

public class TemperatureDBContext : DbContext
{
    public TemperatureDBContext() {}
    
    public TemperatureDBContext(DbContextOptions opts) : base(opts) {}
    
    public DbSet<Temperature> Temperature { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SnakeCaseIdentityTableNames(modelBuilder);
    }

    private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Temperature>(b =>
        {
            b.ToTable("temperature"); 
        });
    }

}