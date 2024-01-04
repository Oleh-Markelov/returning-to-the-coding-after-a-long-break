using Microsoft.EntityFrameworkCore;

namespace WebApp.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebApp.DAL.AppContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("ApplicationContext")));
        }
          
    }
}
