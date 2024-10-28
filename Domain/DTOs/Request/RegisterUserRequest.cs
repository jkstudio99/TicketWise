using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Request;

public class RegisterUserRequest
{

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Role { get; set; }
}