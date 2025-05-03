using DTO.Template.Input;
using EFC.Template.Repositories.Interfaces;
using Ports.Template.Input;
using Ports.Template.Output;

namespace Interactors.Template;

public class CreateWeatherInteractor(IWeatherRepository weatherRepository, ICreateWeatherOutputPort createWeatherOutputPort) : ICreateWeatherInputPort
{
    public async Task Handle(CreateWeatherInputDto input)
    {
        try
        {
            var result = await weatherRepository.CreateWeather(input);
            createWeatherOutputPort.Handle(result);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Excepción en CreateBloqueTimespanInteractor: " + ex.Message);
            throw;
        }
    }
}
