using Domain.Entities;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infastructure;

public class AppDBContext : IdentityDbContext<User>
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Discussion> Discussions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.GenerateSeed();

        builder.Entity<Ticket>()
            .HasOne(e => e.User)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        builder.Entity<Discussion>()
            .HasOne (m => m.Ticket)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}