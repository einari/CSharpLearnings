using System.ComponentModel.DataAnnotations;

namespace ScaryStuff.Weather;

public class WeatherForecast
{
    public DateTime ForDate { get; set; }
    public double Temperature { get; set; }
    public bool WillItRain { get; set; }

    public override string ToString()
    {
        return $"Temperature : {Temperature}, Likely to rain : {WillItRain}";
    }
}