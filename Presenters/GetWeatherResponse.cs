using DTO.Output;
using Patterns.Presenter;
using Patterns.Result;
using Ports.Output;

namespace Presenters;

public class GetWeatherResponse : IGetWeatherOutputPort, IPresenter<Result<GetWeatherOutputDto>>
{
    public Result<GetWeatherOutputDto> Content { get; private set; }

    public void Handle(Result<GetWeatherOutputDto> output) => Content = output;
}
