using System.Linq.Expressions;
using EscrowServices.Auditable;
using EscrowServices.Context;
using EscrowServices.Interfaces.IRepositries;
using EscrowServices.Models;
using Microsoft.EntityFrameworkCore;

namespace EscrowServices.Implementation.Repositries;

public class BaseRepositry<T>:IBaseRepositry<T> where T : BaseEntities, new ()
{
    private readonly ApplicationContext _context;

    public BaseRepositry(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<T> Get(Expression<Func<T, bool>> expression)
    {
        return await _context.Set<T>().Where(expression).FirstOrDefaultAsync();
    }

    public async Task<T> Create(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Delete(T entity)
    {
        await _context.Set<T>().DeleteAsync();
        await _context.SaveChangesAsync();
        return entity;
    }

    public  async Task<T> Get(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public  async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync(); 
    }

    public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression)
    {
        return await _context.Set<T>().Where(expression).ToListAsync();
    }

    public async Task<bool> Exists(Expression<Func<User, bool>> expression)
    {
        return await _context.Set<User>().AnyAsync(expression);
    }

    public async Task<bool> Exists(int id)
    {
        return await _context.Set<T>().AnyAsync(x => x.Id == id && x.IsDeleted == false);
    }
}
