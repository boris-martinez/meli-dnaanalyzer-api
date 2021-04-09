using MediatR;
using Meli.DNAAnalyzer.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Events
{
    public class HumanVerifiedDomainEvent:INotification
    {
        public List<string> dna { get; }
        public bool isMutant { get; }

        public HumanVerifiedDomainEvent(List<string> dna, bool isMutant)
        {
            this.dna = dna;
            this.isMutant = isMutant;
        }
    }
}
