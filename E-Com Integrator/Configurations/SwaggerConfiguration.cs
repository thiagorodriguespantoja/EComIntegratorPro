using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace EComIntegrator.Configurations
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "E-Com Integrator API",
                    Description = "API for integrating Bagy, Bling, and other tools for e-commerce",
                });
            });
        }
    }
}
