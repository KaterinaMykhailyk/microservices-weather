using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WeatherReportDBContext>(
    opts =>
    {
        string connectionString = builder.Configuration.GetConnectionString("AppDb");
        opts.EnableSensitiveDataLogging();
        opts.EnableDetailedErrors();
        opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    },
    ServiceLifetime.Transient
);

var app = builder.Build();

app.Run();