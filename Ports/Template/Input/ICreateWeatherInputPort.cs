using DTO.Template.Input;

namespace Ports.Template.Input;

public interface ICreateWeatherInputPort
{
    Task Handle(CreateWeatherInputDto input);
}
