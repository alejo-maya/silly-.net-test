using FluentValidation;
using MyWebApi.DTOs;

namespace MyWebApi.Validators
{
    public class WeatherForecastValidator : AbstractValidator<WeatherForecastDTO>
    {
        public WeatherForecastValidator()
        {
            RuleFor(x => x.TemperatureC).InclusiveBetween(-30, 50);
            RuleFor(x => x.Summary).NotEmpty().MaximumLength(100);
        }
    }
}
