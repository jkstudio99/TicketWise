namespace Domain.Repository;

public interface IGegenericRepository<T> where T : class
{
    T GetByIdAsync(int id);
    List<T> ListAll();
    void Add(T entity);
    void Update (T entity);
    void Delete(T id);
    void SaveChanges();
}