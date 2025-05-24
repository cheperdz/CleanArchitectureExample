using DTO.Output;
using Patterns.Presenter;
using Patterns.Result;
using Ports.Output;

namespace Presenters;

public class CreateWeatherResponse : ICreateWeatherOutputPort, IPresenter<Result<CreateWeatherOutputDto>>
{
    public Result<CreateWeatherOutputDto> Content { get; private set; }

    public void Handle(Result<CreateWeatherOutputDto> output) => Content = output;
}
