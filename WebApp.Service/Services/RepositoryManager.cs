using Microsoft.Extensions.Configuration;
using WebApp.BLL.Interfaces;

namespace WebApp.BLL.Services
{
    public class RepositoryManager : IRepositoryManager
    {
        private DAL.AppContext _appContext;
        private ITodoRepository _todoRepository;
        private IConfiguration _configuration;

        public RepositoryManager(DAL.AppContext appContext, IConfiguration configuration)
        {
            _appContext = appContext;
            _configuration = configuration;
        }
        public ITodoRepository Todo
        {
            get
            {
                if(_todoRepository is null)
                    _todoRepository = new TodoRepository(_appContext);
                return _todoRepository;
            }
        }

        public async Task SaveAsync() =>
            await _appContext.SaveChangesAsync();
    }
}
