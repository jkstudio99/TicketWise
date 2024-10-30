using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Infastructure;
using Infastructure.Repository;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using TicketWiseUI.Components;
using TicketWiseUI.Security;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddAuthorization();
services.AddCascadingAuthenticationState();
// Add Authentication
services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme);
services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<AppDBContext>()
    .AddSignInManager();
services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = "/login";
    opt.AccessDeniedPath = "/access-denied";
});
services.AddMudServices();
services.AddDbContext<AppDBContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
services.AddScoped<IAccountService, AccountService>();
services.AddScoped<ICriteriaService, CriteriaService>();
services.AddScoped<ITicketService, TicketService>();
services.AddScoped(typeof(EncryptionHelper<>));
services.AddScoped<IUnitOfWork, UnitOfWork>();
services.AddScoped<ITicketRepository, TicketRepository>();
// Add services to the container.
services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();