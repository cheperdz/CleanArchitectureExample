using DTO.Output;
using Patterns.Result;

namespace Ports.Output;

public interface IGetWeatherOutputPort
{
    void Handle(Result<GetWeatherOutputDto> output);
}
