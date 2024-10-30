using System.Collections;
using Domain.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infastructure.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly IdentityDbContext context;
    private Hashtable repositories;
    private IUnitOfWork _unitOfWorkImplementation;

    public UnitOfWork(IdentityDbContext context)
    {
        this.context = context;
    }

    public async Task<int> SaveChange()
    {
        return await context.SaveChangesAsync();
    }

    public async Task<bool> SaveChangeReturnBool()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public IGegenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        if (repositories == null) repositories = new Hashtable();
        var type = typeof(TEntity).Name;
        if (!repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), context);
            repositories.Add(type, repositoryInstance);
        }
        return (IGegenericRepository<TEntity>)repositories[type];
    }
}