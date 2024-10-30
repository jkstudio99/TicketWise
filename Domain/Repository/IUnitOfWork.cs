namespace Domain.Repository;

public interface IUnitOfWork : IDisposable
{
    ITicketRepository TicketRepository { get; }
    IGegenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<int> SaveChange();
    Task<bool> SaveChangeReturnBool();
}