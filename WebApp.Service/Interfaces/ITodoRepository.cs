using WebApp.Domain.Models;

namespace WebApp.BLL.Interfaces
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetAllTodo();
        Task<Todo> GetTodo(int id);
        Task CreateTodo(Todo todo);
        Task Delete(int id);
    }
}
