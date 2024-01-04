using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Models;

namespace WebApp.DAL
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            
        }

        DbSet<Todo> Todos;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
