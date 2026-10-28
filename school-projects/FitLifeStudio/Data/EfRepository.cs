using Microsoft.EntityFrameworkCore;

namespace FitLifeStudio.Data;

public sealed class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly FitLifeDbContext _db;
    private readonly DbSet<TEntity> _set;

    public EfRepository(FitLifeDbContext db)
    {
        _db = db;
        _set = db.Set<TEntity>();
    }

    public async Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _set.AsNoTracking().ToListAsync(cancellationToken);

    public Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        _set.FindAsync([id], cancellationToken).AsTask();

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _set.AddAsync(entity, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var entity = await _set.FindAsync([id], cancellationToken);
        if (entity is null) return;
        _set.Remove(entity);
        await _db.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _set.Update(entity);
        await _db.SaveChangesAsync(cancellationToken);
    }
}
