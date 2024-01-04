using WebApp.BLL.Interfaces;
using WebApp.DAL.GenericRepository.Repository;
using WebApp.Domain.Models;

namespace WebApp.BLL.Services
{
    public class TodoRepository : RepositoryBase<Todo>, ITodoRepository
    {
        private readonly DAL.AppContext _appContext;
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

        public async Task<IEnumerable<Todo>> GetAllTodo()
        {
            IEnumerable<Todo> todos = await FindAllAsync()
        }

        public Task<Todo> GetTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
