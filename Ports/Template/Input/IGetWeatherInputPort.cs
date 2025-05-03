using DTO.Template.Input;

namespace Ports.Template.Input;

public interface IGetWeatherInputPort
{
    Task Handle(GetWeatherInputDto input);
}
