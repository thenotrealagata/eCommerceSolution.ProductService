using eCommerce.DataAccess.Repositories;
using eCommerce.DataAccess.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();

            services.AddScoped<IProductsRepository, ProductsRepository>();
            return services;
        }
    }
}
