using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Meli.DNAAnalyzer.API.Application.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerExtension(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Meli - DNA Analyzer API",
                    Version = "V1",
                    Description = "Service whose target is to analyze the human dna and determine whether it is a mutant or not"
                });
            });

            return services;
        }
    }
}
