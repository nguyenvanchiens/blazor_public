
// ╔═══════════════════════════════════╗
// ║   .*.*. Created by ChienNV .*.*.  ║
// ╚═══════════════════════════════════╝

namespace Extension.Share.Commons;

public class Result<T>
{
    public int Code { get; set; }

    public T? Data { get; set; }

    public string? Message { get; set; }

    public bool IsSuccess => Code == 0;

    public bool IsError => !IsSuccess;

    public Result() { }

    public Result(T data)
    {
        Data = data;
    }

    public Result(string message)
    {
        Message = message;
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>
        {
            Code = 0,
            Data = data,
            Message = "Success"
        };
    }

    public static Result<T> Failure(string message)
    {
        return new Result<T>
        {
            Code = 99,
            Message = message
        };
    }

    public static Result<T> Failure(int code, string message)
    {
        return new Result<T>
        {
            Code = code,
            Message = message
        };
    }
}

public class ErrorResponse
{
    public int StatusCode { get; set; }

    public string? Message { get; set; }

    public Dictionary<string, string[]>? Errors { get; set; }
}