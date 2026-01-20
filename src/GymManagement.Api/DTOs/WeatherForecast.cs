namespace GymManagement.Api.DTOs;

public class WeatherForecast
{
    public DateOnly Date { get; }
    public int TemperatureC { get; }
    public string Summary { get; }

    public WeatherForecast(DateOnly date, int temperatureC, string summary)
    {
        Date = date;
        TemperatureC = temperatureC;
        Summary = summary;
    }
}