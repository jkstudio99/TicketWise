namespace Domain.Repository;

public interface IUnitOfWork : IDisposable
{
    IGegenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<int> SaveChange();
    Task<bool> SaveChangeReturnBool();
}