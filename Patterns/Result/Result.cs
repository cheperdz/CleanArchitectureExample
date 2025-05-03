namespace Patterns.Result;

public class Result<TValue>
{
    private readonly TValue? _value;
    private readonly Error _error;
    // private readonly int _code = 200;
    private readonly bool _isSuccess;

    public bool IsSuccess => _isSuccess;
    public TValue? Value => _value;
    public Error Error => _error;

    private Result(TValue value)
    {
        _isSuccess = true;
        _value = value;
        _error = Error.None;
    }

    private Result(Error error)
    {
        _isSuccess = false;
        _value = default;
        _error = error;
    }

    public static Result<TValue> Success(TValue value) => new(value);
    public static Result<TValue> Failure(Error error) => new(error);

    public static implicit operator Result<TValue>(TValue value) => Success(value);
    public static implicit operator Result<TValue>(Error error) => Failure(error);

    public TResult Match<TResult>
    (
        Func<TValue, TResult> success,
        Func<Error, TResult> failure
    ) => _isSuccess ? success(_value!) : failure(_error);
}

public record Error(int Code, string Message)
{
    public static Error None => new (200, "OK -- No error");
}

public static class GeneralError
{
    // 400's
    public static readonly Error BadRequest = new (400, "Input is not valid");
    public static readonly Error NotFound = new (404, "Id not found");

    // 500's
    public static readonly Error InternalServerError = new (500, "Internal server error"); // public static Error IntrernalServerError(string dbContextName) => new (500, "Error saving changes in database on context: " + dbContextName);

    // public static Error UnhandledError(string exceptionMessage, string innerExceptionMessage = "") => new (-1, exceptionMessage + " \n INNER EXCEPTION:" + string.IsNullOrEmpty(innerExceptionMessage ?? "None"));
}
