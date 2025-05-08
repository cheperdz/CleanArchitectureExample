namespace Patterns.Result;

public record Code(int StatusCode, string Message)
{
    public static Code Ok => new (200, "Successful");
}
