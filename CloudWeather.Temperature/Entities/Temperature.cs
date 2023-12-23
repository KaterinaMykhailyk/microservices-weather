namespace CloudWeather.Temperature.Entities;
public class Temperature
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public decimal TempHighF { get; set; }
    public decimal TempLowF { get; set; }
    public required string ZipCode { get; set; }
}