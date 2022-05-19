using System.Linq.Expressions;
using EscrowServices.Models;

namespace EscrowServices.Interfaces.IRepositries;

public interface IBaseRepositry<T>
{
    Task<T> Get(Expression<Func<T,bool>> expression);
    Task<T> Create(T entity);

    Task<T> Update(T entity);
    Task<T> Delete(T entity);

    Task<T> Get(int id);

    Task<IEnumerable<T>> GetAll();

    Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>> expression);

    Task<bool> Exists(Expression<Func<User,bool>> expression);

    Task<bool> Exists(int id);
}