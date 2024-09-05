using MyWebApi.DTOs;

namespace MyWebApi.Services
{
    public class WeatherService : IWeatherService
    {
        public IEnumerable<WeatherForecastDTO> GetWeather()
        {
            // Simulación de datos de pronósticos de clima
            return new List<WeatherForecastDTO>
            {
                new WeatherForecastDTO { Date = DateTime.Now, TemperatureC = 25, Summary = "Sunny" },
                new WeatherForecastDTO { Date = DateTime.Now.AddDays(1), TemperatureC = 19, Summary = "Cloudy" },
                new WeatherForecastDTO { Date = DateTime.Now.AddDays(2), TemperatureC = 28, Summary = "Partly Cloudy" }
            };
        }
    }
}
