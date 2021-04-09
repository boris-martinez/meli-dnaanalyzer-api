using MediatR;
using Meli.DNAAnalyzer.API.Application.IntegrationEvents;
using Meli.DNAAnalyzer.API.Domain.Events;
using Meli.DNAAnalyzer.API.Infraestructure.Adapters.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Application.DomainEventHandlers
{
    public class HumanVerifiedDomainEventHandler : INotificationHandler<HumanVerifiedDomainEvent>
    {
        private readonly IIntegrationEventService integrationEventService;

        public HumanVerifiedDomainEventHandler(IIntegrationEventService integrationEventService) {

            this.integrationEventService = integrationEventService ?? throw new ArgumentNullException(nameof(integrationEventService));
        }

        public async Task Handle(HumanVerifiedDomainEvent humanVerifiedDomainEvent, CancellationToken cancellationToken)
        {
            await this.integrationEventService.Publish(new HumanVerifiedIntegrationEvent(humanVerifiedDomainEvent.dna, humanVerifiedDomainEvent.isMutant));
        }
    }
}
