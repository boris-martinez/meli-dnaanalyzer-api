using Meli.DNAAnalyzer.API.Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Application.IntegrationEvents
{
    public class HumanVerifiedIntegrationEvent : IntegrationEvent
    {
        public List<string> Dna { get; }
        public bool IsMutant { get; }

        public HumanVerifiedIntegrationEvent(List<string> dna, bool isMutant)
        {
            this.Dna = dna;
            this.IsMutant = isMutant;
        }
    }
}
