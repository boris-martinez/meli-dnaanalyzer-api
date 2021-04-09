using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Meli.DNAAnalyzer.API.Application.Extensions
{
    public static class MediatorExtension
    {
        public static IServiceCollection AddMediatorExtension(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
