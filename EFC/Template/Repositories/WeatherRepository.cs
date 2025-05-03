using DTO.Template.Input;
using DTO.Template.Output;
using EFC.Template.Context;
using EFC.Template.Repositories.Interfaces;
using Entities.Template;
using Patterns.Result;

namespace EFC.Template.Repositories;

public class WeatherRepository(WeatherTemplateDbContext context) : IWeatherRepository
{
    private readonly WeatherTemplateDbContext _context = context;

    public Task<Result<CreateWeatherOutputDto>> CreateWeather(CreateWeatherInputDto input)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(input.Name))
                return Task.FromResult<Result<CreateWeatherOutputDto>>(GeneralError.BadRequest);

            var weather = new Weather { Name = input.Name };
            var valueTask = _context.Weathers.AddAsync(weather);

            Console.WriteLine(valueTask.Result); // TODO => SeriLog
            if (valueTask.IsCompletedSuccessfully)
                _context.SaveChangesAsync();

            var output = new CreateWeatherOutputDto
            {
                Name = weather.Name
            };

            return Task.FromResult(Result<CreateWeatherOutputDto>.Success(output));
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            if (ex.InnerException is not null)
                Console.Write("INNER EX: " + ex.InnerException);

            return Task.FromResult<Result<CreateWeatherOutputDto>>(GeneralError.InternalServerError);
        }
    }


    public Task<Result<GetWeatherOutputDto>> GetWeather(GetWeatherInputDto input)
    {
        try
        {
            if (input.Id <= 0)
                return Task.FromResult<Result<GetWeatherOutputDto>>(GeneralError.BadRequest);

            var weather = _context.Weathers.FirstOrDefault(w => w.Id == input.Id);

            if (weather == null)
                return Task.FromResult<Result<GetWeatherOutputDto>>(GeneralError.NotFound);

            var output = new GetWeatherOutputDto
            {
                Id = weather.Id,
                Name = weather.Name
            };

            return Task.FromResult(Result<GetWeatherOutputDto>.Success(output));
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            if (ex.InnerException is not null)
                Console.Write("INNER EX: " + ex.InnerException);

            return Task.FromResult<Result<GetWeatherOutputDto>>(GeneralError.InternalServerError);
        }
    }
}
