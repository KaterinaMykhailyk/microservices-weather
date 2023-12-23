namespace CloudWeather.Precipitation.Entities;
public class Precipitation
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public decimal AmountInches { get; set; }
    public required string WeatherType { get; set; }
    public required string ZipCode { get; set; }
}