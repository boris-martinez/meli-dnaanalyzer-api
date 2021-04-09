using MediatR;
using Meli.DNAAnalyzer.API.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Infraestructure.Adapters.Messaging
{
    public class NotificationService : INotificationService
    {
        private readonly IMediator mediator;

        public NotificationService(IMediator mediator) {

            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task Notify(INotification notification)
        {
            await this.mediator.Publish(notification);
        }
    }
}
