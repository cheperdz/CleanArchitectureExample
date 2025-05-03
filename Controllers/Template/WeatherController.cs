using DTO.Template.Input;
using DTO.Template.Output;
using Microsoft.AspNetCore.Mvc;
using Patterns.Result;
using Ports.Template.Input;
using Ports.Template.Output;
using Patterns.Presenter;

namespace Controllers.Template;

[ApiController, Route("api/[controller]")]
public class WeatherController
(
    ICreateWeatherInputPort createWeatherInputPort,
    ICreateWeatherOutputPort createWeatherOutputPort,

    IGetWeatherInputPort getWeatherInputPort,
    IGetWeatherOutputPort getWeatherOutputPort
)
{
    [HttpPost("createWeather")]
    public async Task<Result<CreateWeatherOutputDto>> CreateWeather([FromBody] CreateWeatherInputDto input)
    {
        await createWeatherInputPort.Handle(input);
        return ((IPresenter<Result<CreateWeatherOutputDto>>)createWeatherOutputPort).Content;
    }

    [HttpGet("getWeather")]
    public async Task<Result<GetWeatherOutputDto>> GetWeather([FromQuery] GetWeatherInputDto input)
    {
        await getWeatherInputPort.Handle(input);
        return ((IPresenter<Result<GetWeatherOutputDto>>)getWeatherOutputPort).Content;
    }
}
