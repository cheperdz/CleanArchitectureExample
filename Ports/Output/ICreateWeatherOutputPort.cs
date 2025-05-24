using DTO.Output;
using Patterns.Result;

namespace Ports.Output;

public interface ICreateWeatherOutputPort
{
    void Handle(Result<CreateWeatherOutputDto> output);
}
