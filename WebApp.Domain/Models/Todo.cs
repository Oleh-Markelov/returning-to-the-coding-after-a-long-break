using WebApp.Domain.Enum;

namespace WebApp.Domain.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public StatusOfTodo Status { get; set; }
    }
}
