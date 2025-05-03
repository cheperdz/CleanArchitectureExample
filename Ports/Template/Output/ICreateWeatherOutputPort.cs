using DTO.Template.Output;
using Patterns.Result;

namespace Ports.Template.Output;

public interface ICreateWeatherOutputPort
{
    void Handle(Result<CreateWeatherOutputDto> output);
}
