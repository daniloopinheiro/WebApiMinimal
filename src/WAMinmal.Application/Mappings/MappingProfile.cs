using AutoMapper;
using WAMinmal.Application.DTOs;
using WAMinmal.Domain.Entities;

namespace WAMinmal.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Mapeamento entre WeatherForecast e WeatherForecastDTO
        CreateMap<WeatherForecast, WeatherForecastDto>()
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.TemperatureC,
                opt => opt.MapFrom(src => (src.TemperatureF - 32) * 0.5556))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));

        // Mapeamento entre WeatherForecastDTO e WeatherForecast (não é necessário mapear o TemperatureF)
        CreateMap<WeatherForecastDto, WeatherForecast>()
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.TemperatureC,
                opt => opt.MapFrom(src => (src.TemperatureF - 32) * 0.5556))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));

        // Mapeando a entidade WeatherForecast para o DTO WeatherForecastDTO
//        CreateMap<WeatherForecast, WeatherForecastDTO>()
//            .ForMember(dest => dest.TemperatureF, opt => opt.MapFrom(src => 32 + (int)(src.TemperatureC / 0.5556))); // Exemplo de mapeamento customizado

        // Mapeamento entre a entidade de domínio e o DTO
//        CreateMap<WeatherForecast, WeatherForecastDTO>();
//        CreateMap<WeatherForecastDTO, WeatherForecast>();
    }
}
