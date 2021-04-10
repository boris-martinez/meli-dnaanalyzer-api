using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using Meli.DNAAnalyzer.API.Domain.Dto;
using Meli.DNAAnalyzer.API.Infraestructure.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Infraestructure.Adapters.Messaging
{
    public class IntegrationEventService : IIntegrationEventService
    {
        private readonly EventHubProducerClient producerClient;

        public IntegrationEventService(IOptions<ApplicationSettings> settings) {

            ApplicationSettings _settings = settings?.Value ?? throw new ArgumentNullException(nameof(settings));
            this.producerClient = new EventHubProducerClient(_settings.EventHubSettings.ConnectionString, _settings.EventHubSettings.EventHubName);
        }

        public async Task Publish(IntegrationEvent integrationEvent)
        {
            //todo: implementar resilencia
            using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();
            eventBatch.TryAdd(new EventData(Encoding.UTF8.GetBytes(integrationEvent.ToString())));
            await producerClient.SendAsync(eventBatch);
        }
    }
}
