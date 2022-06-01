using Microsoft.AspNetCore.Mvc;

namespace ScaryStuff.Weather;

[Route("/api/weatherforecast")]
public class WeatherForecastController : Controller
{
    static List<WeatherForecast> _forecasts = new();

    [HttpPost]
    public void AddForecast([FromBody] WeatherForecast forecast)
    {
        _forecasts.Add(forecast);
    }

    [HttpGet]
    public List<WeatherForecast> Get()
    {
        return _forecasts;
    }
}