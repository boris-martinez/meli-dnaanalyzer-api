using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Services
{
    public class DnaAnalyzerService : IDnaAnalyzerService
    {
        private readonly INotificationService notificationService;

        public DnaAnalyzerService(INotificationService notificationService) {

            this.notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
        }

        public async Task<bool> IsMutant(List<string> dna)
        {
            //TODO: logica para determinar si es mutante o no
            bool isMutant = true;
            await this.notificationService.Notify(new HumanVerifiedDomainEvent(dna, isMutant));
            return isMutant;
        }
    }
}
