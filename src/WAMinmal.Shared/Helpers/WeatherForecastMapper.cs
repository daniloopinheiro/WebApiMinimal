using WAMinmal.Application.DTOs;
using WAMinmal.Domain.Entities;

namespace WAMinmal.Shared.Helpers;

public static class WeatherForecastMapper
{
    public static WeatherForecastDto ParaDTO(WeatherForecast weatherForecast)
    {
        if(weatherForecast == null ) return null;

        return new WeatherForecastDto
        {
            Date = weatherForecast.Date,
            TemperatureC = weatherForecast.TemperatureC,
            Summary = weatherForecast.Summary
        };
    }

    public static WeatherForecast ParaDomain(WeatherForecastDto weatherForecastDTO)
    {
        if(weatherForecastDTO == null) return null;

        return new WeatherForecast
        {
            Date = weatherForecastDTO.Date,
            TemperatureC = weatherForecastDTO.TemperatureC,
            Summary = weatherForecastDTO.Summary
        };
    }
}