using Microsoft.AspNetCore.Mvc;
using WebApp.BLL.Interfaces;
using WebApp.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private readonly IRepositoryManager _repositoryManager;

        public TodoController(IRepositoryManager repositoryManager, ILogger<TodoController> logger)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
        }

        // GET: api/<TodoController>
        [HttpGet]
        public IEnumerable<Todo> GetAll()
        {
            return (IEnumerable<Todo>)_repositoryManager.Todo.GetAllTodo();
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public async Task<Todo> Get(int id)
        {
            return await _repositoryManager.Todo.GetTodo(id);
        }

        // POST api/<TodoController>
        [HttpPost]
        public void Create(string Title, string Description)
        {
            Todo todo = new()
            {
                Title = Title,
                Description = Description,
                Status = Domain.Enum.StatusOfTodo.Pending
            };
            _repositoryManager.Todo.CreateTodo(todo);
            _repositoryManager.SaveAsync();
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
