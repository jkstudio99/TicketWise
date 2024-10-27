using Domain.DTOs.Response;
using Microsoft.AspNetCore.Identity.Data;

namespace Domain.Interfaces;

public interface IAccountService
{
    Task<BaseResponse<string>> VerifyUser(string email, string password);
    Task<BaseResponse> RegisterUser(RegisterRequest request);
    
}