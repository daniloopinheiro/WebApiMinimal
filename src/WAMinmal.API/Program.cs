using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

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

app.Run();
