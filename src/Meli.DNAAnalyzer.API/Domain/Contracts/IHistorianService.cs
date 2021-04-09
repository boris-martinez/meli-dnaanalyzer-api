using Meli.DNAAnalyzer.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Contracts
{
    public interface IHistorianService
    {
        Task<Statistic> GetStatistics();
    }
}
