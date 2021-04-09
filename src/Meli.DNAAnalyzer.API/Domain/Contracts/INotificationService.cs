using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Contracts
{
    public interface INotificationService
    {
        Task Notify(INotification notification);
    }
}
