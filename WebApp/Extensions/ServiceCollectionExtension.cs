using Microsoft.EntityFrameworkCore;
using WebApp.BLL.Interfaces;
using WebApp.BLL.Services;

namespace WebApp.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebApp.DAL.AppContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("ApplicationContext")));
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
            => services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
