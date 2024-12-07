using WAMinmal.Domain.Entities;

namespace WAMinmal.Domain.Interfaces;

public interface IWeatherForecastRepository
{
    Task<WeatherForecast> GetWeatherForecastByDateAsync(DateTime date);
    Task<IEnumerable<WeatherForecast>> GetAllWeatherForecastsAsync();
    Task AddWeatherForecastAsync(WeatherForecast forecast);
    Task UpdateWeatherForecastAsync(WeatherForecast forecast);
    Task DeleteWeatherForecastAsync(WeatherForecast forecast);
}
