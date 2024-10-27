namespace Domain.DTOs.Response;

public class BaseResponse
{
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; } = String.Empty; 
}

public class BaseResponse<T>
{
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; } = String.Empty;
    public T Value { get; set; }
}