using DTO.Template.Output;
using Patterns.Result;

namespace Ports.Template.Output;

public interface IGetWeatherOutputPort
{
    void Handle(Result<GetWeatherOutputDto> output);
}
