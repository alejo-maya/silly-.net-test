using MyWebApi.DTOs;

namespace MyWebApi.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecastDTO> GetWeather();
    }
}
