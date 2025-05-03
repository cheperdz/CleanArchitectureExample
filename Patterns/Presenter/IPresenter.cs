namespace Patterns.Presenter;

public interface  IPresenter<TFormatDataType>
{
    public TFormatDataType Content { get; }
}
