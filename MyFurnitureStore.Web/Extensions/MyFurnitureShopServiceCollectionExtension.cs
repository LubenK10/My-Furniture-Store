using MyFurnitureShop.Core.Contracts;
using MyFurnitureShop.Core.Services;
using MyFurnitureShop.Infrastructure.Data.Common;

namespace MyFurnitureShop.Extensions.DependencyInjection
{
    public static class MyFurnitureShopServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICartService, CartService>();
            return services;
        }
    }
}
