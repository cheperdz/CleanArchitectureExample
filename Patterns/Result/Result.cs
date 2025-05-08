namespace Patterns.Result;

public class Result<TValue>
{
    private readonly TValue? _value;
    private readonly Code _code;
    private readonly bool _isSuccess;

    public bool IsSuccess => _isSuccess;
    public TValue? Value => _value;
    public Code Code => _code;

    private Result(TValue value)
    {
        _isSuccess = true;
        _value = value;
        _code = Code.Ok;
    }

    private Result(Code code)
    {
        _isSuccess = false;
        _value = default;
        _code = code;
    }

    public static Result<TValue> Success(TValue value) => new(value);
    public static Result<TValue> Failure(Code code) => new(code);

    public static implicit operator Result<TValue>(TValue value) => Success(value);
    public static implicit operator Result<TValue>(Code code) => Failure(code);

    public TResult Match<TResult>
    (
        Func<TValue, TResult> success,
        Func<Code, TResult> failure
    ) => _isSuccess ? success(_value!) : failure(_code);
}
