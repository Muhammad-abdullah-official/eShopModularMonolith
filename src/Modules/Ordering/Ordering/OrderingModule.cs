using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering;

public static class OrderingModule
{
    public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
    {
        // Register services specific to the Ordering module
        //services.AddScoped<IOrderingService, OrderingService>(); 
        //services.AddScoped<IOrderingRepository, OrderingRepository>();
        // Add any additional services or configurations needed for the Ordering module
        return services;
    }

    public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline for the Catalog module 
        // .UseApplicationServices()
        // .UseInfrastructureServices()
        // .UseApiServices()
        return app;
    }

}