using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket;

public static class BasketModule
{
    public static IServiceCollection AddBasketModule
        (this IServiceCollection services, IConfiguration configuration)
    {
        // Register services specific to the Basket module
        //services.AddScoped<IBasketService, BasketService>(); 
        //services.AddScoped<IBasketRepository, BasketRepository>();
        // Add any additional services or configurations needed for the Basket module
        return services;
    }

    public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline for the Catalog module 
        // .UseApplicationServices()
        // .UseInfrastructureServices()
        // .UseApiServices()
        return app;
    }

}
