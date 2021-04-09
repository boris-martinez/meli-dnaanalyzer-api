using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Entities;
using Meli.DNAAnalyzer.API.Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Infraestructure.Adapters.Messaging
{
    public class IntegrationEventService : IIntegrationEventService
    {
        public IntegrationEventService() {
        
        }

        public async Task Publish(IntegrationEvent integrationEvent)
        {
            //TODO: Implementar envio al event hub
            Console.WriteLine("Mensaje enviado");
        }
    }
}
