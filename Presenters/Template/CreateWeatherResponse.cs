using DTO.Template.Output;
using Patterns.Presenter;
using Patterns.Result;
using Ports.Template.Output;

namespace Presenters.Template;

public class CreateWeatherResponse : ICreateWeatherOutputPort, IPresenter<Result<CreateWeatherOutputDto>>
{
    public Result<CreateWeatherOutputDto> Content { get; private set; }

    public void Handle(Result<CreateWeatherOutputDto> output) => Content = output;
}
