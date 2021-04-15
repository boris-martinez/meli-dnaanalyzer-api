﻿using Azure.Messaging.EventHubs;
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
        private EventHubProducerClient producerClient;
        private readonly ApplicationSettings settings;

        public IntegrationEventService(IOptions<ApplicationSettings> settings) {

            this.settings = settings?.Value ?? throw new ArgumentNullException(nameof(settings));
            this.producerClient = new EventHubProducerClient(this.settings.EventHubSettings.ConnectionString, this.settings.EventHubSettings.EventHubName);
        }

        public async Task Publish(IntegrationEvent integrationEvent)
        {
            //todo: implementar resilencia
            if(this.producerClient.IsClosed)
                this.producerClient = new EventHubProducerClient(this.settings.EventHubSettings.ConnectionString, this.settings.EventHubSettings.EventHubName);

            using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();
            eventBatch.TryAdd(new EventData(Encoding.UTF8.GetBytes(integrationEvent.ToString())));
            await producerClient.SendAsync(eventBatch);
        }
    }
}
