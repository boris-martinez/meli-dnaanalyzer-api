using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Contracts
{
    public interface IDnaAnalyzerService
    {
        Task<bool> IsMutant(List<string> dna);
    }
}
