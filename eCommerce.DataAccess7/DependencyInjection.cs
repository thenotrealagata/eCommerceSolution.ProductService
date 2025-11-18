using eCommerce.DataAccess.Repositories;
using eCommerce.DataAccess.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options
                .UseSqlServer(connectionString)
            );

            services.AddSingleton<IProductsRepository, ProductsRepository>();
            return services;
        }
    }
}
