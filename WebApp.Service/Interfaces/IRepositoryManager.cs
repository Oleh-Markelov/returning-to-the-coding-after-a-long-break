namespace WebApp.BLL.Interfaces
{
    public interface IRepositoryManager
    {
        ITodoRepository Todo { get; }
        Task SaveAsync();
    }
}
