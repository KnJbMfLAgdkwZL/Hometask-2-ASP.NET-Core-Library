using DataAccess.Interfaces;
using Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Database.DbContexts;

namespace DataAccess.Repositories;

public class GeneralRepository<T> : IGeneralRepository<T> where T : class
{
    private readonly DbSet<T> _table;
    private readonly MasterContext _masterContext;

    public GeneralRepository(
        MasterContext masterContext
    )
    {
        _masterContext = masterContext;
        _table = _masterContext.Set<T>();
    }

    public async Task<T> AddAsync(T model, CancellationToken token)
    {
        var entityEntry = await _table.AddAsync(model, token);

        await _masterContext.SaveChangesAsync(token);

        return entityEntry.Entity;
    }

    public async Task<T> AddIfNotExistAsync(Expression<Func<T, bool>> condition, T model,
        CancellationToken token)
    {
        var result = await GetOneAsync(condition, token) ?? await AddAsync(model, token);

        return result;
    }

    public async Task<T> AddOrUpdateAsync(Expression<Func<T, bool>> condition, T model, CancellationToken token)
    {
        var result = await GetOneAsync(condition, token);

        T modelRes;

        if (result == null)
        {
            modelRes = await AddAsync(model, token);
        }
        else
        {
            DetachEntity(result);

            ((IEntity) model).Id = ((IEntity) result).Id;

            modelRes = result;

            await UpdateAsync(model, token);
        }

        return modelRes;
    }

    public async Task<T> RemoveAsync(T model, CancellationToken token)
    {
        var entityEntry = _table.Remove(model);

        await _masterContext.SaveChangesAsync(token);

        return entityEntry.Entity;
    }

    public async Task<T> RemoveIfExistAsync(Expression<Func<T, bool>> condition, CancellationToken token)
    {
        var result = await GetOneAsync(condition, token);

        T modelRes = null!;

        if (result != null)
        {
            modelRes = await RemoveAsync(result, token);
        }

        return modelRes;
    }

    public async Task RemoveRangeAsync(Expression<Func<T, bool>> condition, CancellationToken token)
    {
        var rows = await GetAllAsync(condition, token);

        _table.RemoveRange(rows);

        await _masterContext.SaveChangesAsync(token);
    }

    public async Task<T> UpdateAsync(T model, CancellationToken token)
    {
        var entityEntry = _table.Update(model);

        await _masterContext.SaveChangesAsync(token);

        return entityEntry.Entity;
    }

    public async Task<List<T>> GetAllAsync(CancellationToken token)
    {
        return await _table.ToListAsync(token);
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> condition, CancellationToken token)
    {
        return await _table.Where(condition).ToListAsync(token);
    }

    public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> condition,
        Expression<Func<T, TKey>> orderBy, CancellationToken token)
    {
        return await _table.Where(condition).OrderBy(orderBy).ToListAsync(token);
    }

    public async Task<List<T>> GetAllDescendingAsync<TKey>(Expression<Func<T, bool>> condition,
        Expression<Func<T, TKey>> orderBy, CancellationToken token)
    {
        return await _table.Where(condition).OrderByDescending(orderBy).ToListAsync(token);
    }

    public async Task<List<T>> GetAllIncludeAsync<TKey>(Expression<Func<T, bool>> condition,
        Expression<Func<T, TKey>> include, CancellationToken token)
    {
        return await _table.Where(condition).Include(include).ToListAsync(token);
    }

    public async Task<List<T>> GetAllIncludeManyAsync<TKey>(Expression<Func<T, bool>> condition,
        IEnumerable<Expression<Func<T, TKey>>> includes, CancellationToken token)
    {
        var r = _table.Where(condition);

        r = includes.Aggregate(r, (current, include) => current.Include(include));

        return await r.ToListAsync(token);
    }

    public async Task<List<T>> GetAllIncludeManyAsync<TKey>(
        Expression<Func<T, bool>> condition,
        IEnumerable<Expression<Func<T, TKey>>> includes,
        Expression<Func<T, TKey>> orderBy,
        CancellationToken token)
    {
        var r = _table.Where(condition);

        r = includes.Aggregate(r, (current, include) => current.Include(include));

        r = r.OrderBy(orderBy);

        return await r.ToListAsync(token);
    }

    public async Task<List<T>> GetAllIncludeManyDescendingAsync<TKey>(Expression<Func<T, bool>> condition,
        IEnumerable<Expression<Func<T, TKey>>> includes, Expression<Func<T, TKey>> orderBy, CancellationToken token)
    {
        var r = _table.Where(condition);

        r = includes.Aggregate(r, (current, include) => current.Include(include));

        return await r.OrderByDescending(orderBy).ToListAsync(token);
    }

    public async Task<T?> GetOneAsync(Expression<Func<T, bool>> condition, CancellationToken token)
    {
        return await _table.Where(condition).FirstOrDefaultAsync(token);
    }

    public async Task<T?> GetOneIncludeAsync<TKey>(Expression<Func<T, bool>> condition,
        Expression<Func<T, TKey>> include, CancellationToken token)
    {
        return await _table.Where(condition).Include(include).FirstOrDefaultAsync(token);
    }

    public async Task<T?> GetOneIncludeManyAsync<TKey>(Expression<Func<T, bool>> condition,
        IEnumerable<Expression<Func<T, TKey>>> includes, CancellationToken token)
    {
        var r = _table.Where(condition);

        r = includes.Aggregate(r, (current, include) => current.Include(include));

        return await r.FirstOrDefaultAsync(token);
    }

    public async Task<double?> AverageAsync(Expression<Func<T, bool>> condition, Expression<Func<T, int?>> selector,
        CancellationToken token)
    {
        return await _table.Where(condition).AverageAsync(selector, token);
    }

    public void DetachEntity(T model)
    {
        _masterContext.Entry(model).State = EntityState.Detached;
    }
}