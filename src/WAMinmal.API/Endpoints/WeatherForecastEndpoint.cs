using WAMinmal.Application.DTOs;

namespace WAMinmal.API.Endpoints;

public static class WeatherForecastEndpoint
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public static void MapWeatherForecastEndpoints(this WebApplication app)
    {
        // Definindo o endpoint para "GetWeatherForecast"
        app.MapGet("/weatherforecast", () =>
        {
//            ILogger<WeatherForecastEndpoint> logger
//            if (logger == null) throw new ArgumentNullException(nameof(logger));
//            logger.LogInformation("Fetching weather forecasts");

            var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();

            return Results.Ok(forecasts);  // Retorna um resultado de sucesso com os dados
        });
    }
}