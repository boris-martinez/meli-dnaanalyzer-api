using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Meli.DNAAnalyzer.API.Application.Extensions
{
    public static class HealthCheckExtension
    {
        private const string HealCheckName = "ReadinessLiveness";

        public static IServiceCollection AddHealthCheckExtension(this IServiceCollection services)
        {
            services.AddHealthChecks().AddCheck(
             HealCheckName,
             () => HealthCheckResult.Healthy("OK"));

            return services;
        }
    }
}
