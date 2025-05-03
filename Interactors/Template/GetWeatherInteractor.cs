using DTO.Template.Input;
using Ports.Template.Input;

namespace Interactors.Template;

public class GetWeatherInteractor : IGetWeatherInputPort
{
    public Task Handle(GetWeatherInputDto input)
    {
        throw new NotImplementedException();
    }
}
