using DTO.Template.Input;
using Ports.Template.Input;

namespace Interactors.Template;

public class CreateWeatherInteractor : ICreateWeatherInputPort
{
    public Task Handle(CreateWeatherInputDto input)
    {
        throw new NotImplementedException();
    }
}
