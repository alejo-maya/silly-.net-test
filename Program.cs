using MyWebApi.Middleware;
using MyWebApi.Services;
using FluentValidation;
using MyWebApi.Validators;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();
builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddValidatorsFromAssemblyContaining<WeatherForecastValidator>();

// Configurar Swagger para la documentación de la API.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware personalizado para manejo de excepciones.
app.UseMiddleware<ExceptionHandlingMiddleware>();

// Configuración del pipeline HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello, World!");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
