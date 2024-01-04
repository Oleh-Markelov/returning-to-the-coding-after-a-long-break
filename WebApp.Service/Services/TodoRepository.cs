using Microsoft.EntityFrameworkCore;
using WebApp.BLL.Interfaces;
using WebApp.DAL.GenericRepository.Repository;
using WebApp.Domain.Models;

namespace WebApp.BLL.Services
{
    public class TodoRepository : RepositoryBase<Todo>, ITodoRepository
    {
        public TodoRepository(DAL.AppContext appContext) : base(appContext)
        {
            _appContext = appContext;
        }

        public async Task CreateTodo(Todo todo)
        {
            await CreateAsync(todo);
        }

        public async Task Delete(int id)
        {
            await Delete(id);
        }

        public async Task<IQueryable<Todo>> GetAllTodo()
        {
            //IQueryable<Todo> todo = await GetAllAsync();
            var test = (IQueryable<Todo>)await FindByConditionAsync(null, trackChanges: false).Result.ToListAsync();
            return test;
        }

        public async Task<Todo> GetTodo(int id)
        {
            Todo todo = await FindByConditionAsync(e => e.Id.Equals(id), trackChanges: false).Result.SingleOrDefaultAsync();
            return todo;
        }
    }
}
