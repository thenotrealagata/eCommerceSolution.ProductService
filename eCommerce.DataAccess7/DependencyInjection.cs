using eCommerce.DataAccess.Repositories;
using eCommerce.DataAccess.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace eCommerce.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MySQLConnection")!
                .Replace("$MYSQL_HOST", Environment.GetEnvironmentVariable("MYSQL_HOST"))
                .Replace("$MYSQL_PASSWORD", Environment.GetEnvironmentVariable("MYSQL_PASSWORD"));

            services.AddDbContext<ApplicationDbContext>(
                opts => opts.UseMySQL(connectionString)
            );

            services.AddScoped<IProductsRepository, ProductsRepository>();
            return services;
        }
    }
}
