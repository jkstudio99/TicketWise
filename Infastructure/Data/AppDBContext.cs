using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infastructure;

public class AppDBContext : IdentityDbContext<User>
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        
    }
}