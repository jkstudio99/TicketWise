using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Repository;

public class GenericRepository<T>: IGegenericRepository<T> where T : class
{
    internal readonly IdentityDbContext dbContext;

    public GenericRepository(IdentityDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public T GetByIdAsync(int id)
    {
        return dbContext.Set<T>().Find(id);
    }

    public List<T> ListAll()
    {
        return dbContext.Set<T>().ToList();
    }

    public void Add(T entity)
    {
        dbContext.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        dbContext.Set<T>().Attach(entity);
        dbContext.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        dbContext.Set<T>().Remove(entity);
    }

    public void SaveChanges()
    {
        dbContext.SaveChanges();
    }
}