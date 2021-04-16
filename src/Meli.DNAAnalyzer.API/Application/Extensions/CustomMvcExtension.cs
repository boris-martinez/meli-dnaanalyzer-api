using Meli.DNAAnalyzer.API.Application.Controllers;
using Meli.DNAAnalyzer.API.Application.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Meli.DNAAnalyzer.API.Application.Extensions
{
    public static class CustomMvcExtension
    {
        public static IServiceCollection AddCustomMvcExtension(this IServiceCollection services)
        {
            services. AddControllers(options =>
            {
                options.Filters.Add(typeof(HttpGlobalExceptionFilter));
            })
            // Added for integration tests
            .AddApplicationPart(typeof(MutantController).Assembly)
            .AddNewtonsoftJson()
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);


            return services;
        }
    }
}
