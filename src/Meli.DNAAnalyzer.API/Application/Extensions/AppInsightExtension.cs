using Meli.DNAAnalyzer.API.Application.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meli.DNAAnalyzer.API.Application.Extensions
{
    public static class AppInsightExtension
    {
        public static IServiceCollection AddAppInsight(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationInsightsTelemetry(configuration);
            services.AddApplicationInsightsTelemetryProcessor<TelemetryFilterProcessor>();
            services.AddApplicationInsightsKubernetesEnricher();

            return services;
        }
    }
}
