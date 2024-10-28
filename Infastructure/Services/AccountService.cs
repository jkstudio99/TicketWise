using Azure;
using Domain.DTOs.Request;
using Domain.DTOs.Response;
using Domain.Entities;
using Domain.Interfaces;
using Infastructure.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public AccountService(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public async Task<BaseResponse> RegisterUser(RegisterUserRequest request)
        {
            User user = new User
            {
                UserName = request.Email,
                Email = request.Email,
                AccountConfirmed = false
            };
            string password = Constants.DEFAULT_PASSWORD;

            var result = await signInManager.UserManager.CreateAsync(user, password);
            return new BaseResponse
            {
                IsSuccess = result.Succeeded
            };
        }

        public async Task<BaseResponse<string>> VerifyUser(string email, string password)
        {
            BaseResponse<string> response = new();

            var user = await signInManager.UserManager.FindByEmailAsync(email);

            if (user is null)
            {
                response.ErrorMessage = "Invalid email or password";
                response.IsSuccess = false;
                return response;
            }

            var result = await signInManager.UserManager.CheckPasswordAsync(user, password);
            response.IsSuccess = result;

            if (!result)
            {
                response.ErrorMessage = "Invalid email or password";
            }
            else
            {
                response.Value = user.UserName;
            }

            return response;
        }
    }
}