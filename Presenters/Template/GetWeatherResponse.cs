using DTO.Template.Output;
using Patterns.Presenter;
using Patterns.Result;
using Ports.Template.Output;

namespace Presenters.Template;

public class GetWeatherResponse : IGetWeatherOutputPort, IPresenter<Result<GetWeatherOutputDto>>
{
    public Result<GetWeatherOutputDto> Content { get; private set; }

    public void Handle(Result<GetWeatherOutputDto> output) => Content = output;
}
