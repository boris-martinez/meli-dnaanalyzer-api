using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meli.DNAAnalyzer.API.Application.Extensions
{
    public static class DependenciesExtension
    {
        public static IServiceCollection AddDependenciesExtension(this IServiceCollection services, IConfiguration configuration)
        {
            //Settings
            //services.Configure<ApplicationSettings>(configuration);

            //Infraestructure
            //services.AddSingleton<ITripRepository, TripInMemoryRepository>();
            //services.AddSingleton<ITripRepository, TripRepository>();

            return services;
        }
    }
}
