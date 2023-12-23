using Microsoft.EntityFrameworkCore;
using CloudWeather.Precipitation.Entities;
public class PrecipDBContext : DbContext
{
    public PrecipDBContext() {}

    public PrecipDBContext(DbContextOptions opts) : base(opts)
    {
    }
    
    public DbSet<Precipitation> Precipitation { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SnakeCaseIdentityTableNames(modelBuilder);
    }

    private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<Precipitation>(b => { b.ToTable("precipitation"); });
    }
}