using JobFinder.Infrastructure.Data;

namespace JobFinder.Infrastructure.Repositories;

internal sealed class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _context;

    public GenericRepository(ApplicationDbContext context)
        => _context = context;

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _context.Set<TEntity>().ToListAsync();

    public async Task AddAsync(TEntity entity)
    {
        await _context.AddAsync(entity);

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _context.Remove(entity);

        await _context.SaveChangesAsync();
    }
}
