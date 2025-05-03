using DTO.Template.Input;
using EFC.Template.Repositories.Interfaces;
using Ports.Template.Input;
using Ports.Template.Output;

namespace Interactors.Template;

public class GetWeatherInteractor(IWeatherRepository weatherRepository, IGetWeatherOutputPort getWeatherOutputPort) : IGetWeatherInputPort
{
    public async Task Handle(GetWeatherInputDto input)
    {
        try
        {
            var result = await weatherRepository.GetWeather(input);
            getWeatherOutputPort.Handle(result);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Excepción en CreateBloqueTimespanInteractor: " + ex.Message);
            throw;
        }
    }
}
