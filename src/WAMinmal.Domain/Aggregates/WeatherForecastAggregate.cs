using WAMinmal.Domain.Entities;

namespace WAMinmal.Domain.Aggregates;

public class WeatherForecastAggregate
{
    public List<WeatherForecast> Forecasts { get; set; } = new List<WeatherForecast>();
}
