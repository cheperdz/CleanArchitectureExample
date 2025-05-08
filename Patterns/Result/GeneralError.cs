namespace Patterns.Result;

public static class GeneralError
{
    // 400's
    public static readonly Code BadRequest = new (400, "Input is not valid");
    public static readonly Code NotFound = new (404, "Id not found");

    // 500's
    public static readonly Code InternalServerError = new (500, "Internal server error");
}
