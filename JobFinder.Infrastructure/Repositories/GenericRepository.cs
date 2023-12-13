using JobFinder.Infrastructure.Data;

namespace JobFinder.Infrastructure.Repositories;

// Change: Changed T:entity to be BasicEntity
internal sealed class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BasicEntity
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

    public async Task<TEntity> GetByIdAsync(Guid Id) 
        => await _context.Set<TEntity>().FirstOrDefaultAsync(en => en.Id == Id);

    public async Task<List<TEntity>> GetByIdListAsync(List<Guid> Ids)
        => await _context.Set<TEntity>().Where(en => Ids.Contains(en.Id)).ToListAsync();
}
