using Meli.DNAAnalyzer.API.Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Infraestructure.Adapters.Messaging
{
    public interface IIntegrationEventService
    {
        Task Publish(IntegrationEvent integrationEvent);
    }
}
