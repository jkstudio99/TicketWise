using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class User : IdentityUser
{
    public string? Avartar { get; set; }
    public bool AccountConfirmed { get; set; } 
}