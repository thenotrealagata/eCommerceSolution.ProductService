using eCommerce.DataAccess.Repositories;
using eCommerce.DataAccess.RepositoryContracts;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IProductsRepository, ProductsRepository>();
            services.AddSingleton<ApplicationDbContext>();
            return services;
        }
    }
}
