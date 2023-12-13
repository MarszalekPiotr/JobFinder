namespace JobFinder.Application.Repository;

public interface IGenericRepository<TEntity>
{
    public Task<IEnumerable<TEntity>> GetAllAsync();
    public Task AddAsync(TEntity entity);
    public Task DeleteAsync(TEntity entity);
    Task<TEntity> GetByIdAsync(Guid Id);
    Task<List<TEntity>> GetByIdListAsync(List<Guid> Ids);
}
