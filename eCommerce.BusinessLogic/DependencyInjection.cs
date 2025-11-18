using eCommerce.BusinessLogic.ServiceContracts;
using eCommerce.BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.BusinessLogic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            // Register business logic services here
            services.AddSingleton<IProductsService, ProductsService>();
            return services;
        }
    }
}
