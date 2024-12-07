using System.ComponentModel.DataAnnotations;

namespace WAMinmal.Application.DTOs;

public class WeatherForecastDto
{
    [Required]  // Exige que a data seja informada
    [DataType(DataType.Date)]  // Especifica que o tipo de dado é uma data
    public DateTime Date { get; set; }  // Data da previsão

    [Range(-100, 100)]  // Define o intervalo permitido para a temperatura (em Celsius)
    public int TemperatureC { get; set; }  // Temperatura em Celsius

    [Range(-148, 212)]  // Define o intervalo permitido para a temperatura em Fahrenheit
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);  // Temperatura em Fahrenheit (cálculo automático)

    [StringLength(100)]  // Limita o comprimento máximo do texto para o resumo da previsão
    public string? Summary { get; set; }  // Resumo da previsão, que pode ser nulo
}