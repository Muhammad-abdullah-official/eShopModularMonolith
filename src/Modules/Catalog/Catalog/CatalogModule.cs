using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog;
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
        // add services to the container
        // .AddApplicationServices()
        // .AddInfrastructureServices(configuration)
        // .AddApiServices(configuration)
        return services;
        }


    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline for the Catalog module 
        // .UseApplicationServices()
        // .UseInfrastructureServices()
        // .UseApiServices()
        return app;
    }

}

