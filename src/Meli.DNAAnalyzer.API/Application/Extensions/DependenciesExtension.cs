using MediatR;
using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Services;
using Meli.DNAAnalyzer.API.Infraestructure.Adapters.Messaging;
using Meli.DNAAnalyzer.API.Infraestructure.Adapters.Persistance;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Meli.DNAAnalyzer.API.Application.Extensions
{
    public static class DependenciesExtension
    {
        public static IServiceCollection AddDependenciesExtension(this IServiceCollection services, IConfiguration configuration)
        {
            //Settings
            //services.Configure<ApplicationSettings>(configuration);

            services.AddMediatR(Assembly.GetExecutingAssembly());

            //Domain
            services.AddSingleton<INotificationService, NotificationService>();
            services.AddSingleton<IDnaAnalyzerService, DnaAnalyzerService>();
            services.AddSingleton<IHistorianService, HistorianService>();

            //Infraestructure
            services.AddSingleton<IIntegrationEventService, IntegrationEventService>();
            services.AddSingleton<IStatisticRepository, StatisticRepository>();

            return services;
        }
    }
}
