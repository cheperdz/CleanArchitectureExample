using DTO.Input;

namespace Ports.Input;

public interface IGetWeatherInputPort
{
    Task Handle(GetWeatherInputDto input);
}
