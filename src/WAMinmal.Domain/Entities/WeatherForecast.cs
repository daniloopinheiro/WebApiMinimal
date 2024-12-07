namespace WAMinmal.Domain.Entities;

public class WeatherForecast
{
    public DateTime Date { get; set; }    // Data da previsão
    public int TemperatureC { get; set; } // Temperatura em Celsius
    public int TemperatureF { get; set; } // Temperatura em Fahrenheit (cálculo automático)
    public string? Summary { get; set; }  // Resumo da previsão, que pode ser nulo
}
