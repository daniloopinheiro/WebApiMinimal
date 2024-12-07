using Microsoft.OpenApi.Models;
using WAMinmal.API.Endpoints;
using WAMinmal.Application.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Adicionando AutoMapper ao DI container
//builder.Services.AddAutoMapper(typeof(MappingProfile)); // Registra o perfil de mapeamento

// Adiciona o serviço CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()  // Permite qualquer origem (você pode restringir isso depois)
              .AllowAnyMethod()   // Permite qualquer método HTTP (GET, POST, etc.)
              .AllowAnyHeader()); // Permite qualquer cabeçalho
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API Minimal Swagger Example",
        Version = "v1",
        Description = "Exemplo de uma API simples com DDD e Swagger.",
        Contact = new OpenApiContact
        {
            Name = "Danilo O. Pinheiro",
            Url = new Uri("https://www.linkedin.com/in/daniloopinheiro/")
        }
    });
});

var app = builder.Build();

// Aplicar a política CORS para permitir qualquer origem, método e cabeçalho
app.UseCors("AllowAll");

// Configuração do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita o Swagger
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Minimal Swagger Example v1");
        c.RoutePrefix = string.Empty; // A UI do Swagger será acessível diretamente pela raiz (http://localhost:5000)
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapWeatherForecastEndpoints();
app.Run();
