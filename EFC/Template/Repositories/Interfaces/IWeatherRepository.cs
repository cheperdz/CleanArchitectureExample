using DTO.Input;
using DTO.Output;
using Patterns.Result;

namespace EFC.Template.Repositories.Interfaces;

public interface IWeatherRepository
{
    Task<Result<CreateWeatherOutputDto>> CreateWeather(CreateWeatherInputDto input);
    Task<Result<GetWeatherOutputDto>> GetWeather(GetWeatherInputDto input);
}
