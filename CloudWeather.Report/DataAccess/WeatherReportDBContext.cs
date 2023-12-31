using CloudWeather.Report.Entities;
using Microsoft.EntityFrameworkCore;

public class WeatherReportDBContext : DbContext
{
    public WeatherReportDBContext() {}
    public WeatherReportDBContext(DbContextOptions opts) : base(opts) {}
    
    public DbSet<WeatherReport> WeatherReports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SnakeCaseIdentityTableNames(modelBuilder);
    }

    private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherReport>(b => { b.ToTable("weather_report"); });
    }
}