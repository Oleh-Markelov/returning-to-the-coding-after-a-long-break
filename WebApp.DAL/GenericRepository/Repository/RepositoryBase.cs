using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.DAL.GenericRepository.Interfaces;

namespace WebApp.DAL.GenericRepository.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppContext _appContext;
        public RepositoryBase(AppContext appContext)
        {
            _appContext = appContext;
        }
        public async Task CreateAsync(T entity)
        {
            await Task.Run(() => _appContext.Set<T>().Add(entity));
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {

           return (IQueryable<T>)await Task.Run(() => _appContext.Set<T>().ToListAsync());
        }

        public async Task<IQueryable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            if (trackChanges)
            {
                return await Task.Run(() => _appContext.Set<T>().Where(expression).AsNoTracking());
            }
            else
            {
                return await Task.Run(() => _appContext.Set<T>().Where(expression));
            }
        }

        public async Task RemoveAsync(T entity)
        {
            await Task.Run(() => _appContext.Set<T>().Remove(entity));
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => _appContext.Set<T>().Update(entity));
        }
    }
}
