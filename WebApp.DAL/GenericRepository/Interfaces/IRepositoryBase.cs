using System.Linq.Expressions;

namespace WebApp.DAL.GenericRepository.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
