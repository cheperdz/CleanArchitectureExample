using DTO.Input;

namespace Ports.Input;

public interface ICreateWeatherInputPort
{
    Task Handle(CreateWeatherInputDto input);
}
