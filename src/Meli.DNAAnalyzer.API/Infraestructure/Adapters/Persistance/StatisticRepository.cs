using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Infraestructure.Adapters.Persistance
{
    public class StatisticRepository : IStatisticRepository
    {
        public async Task<Statistic> Get()
        {
            await Task.CompletedTask;
            return new Statistic(12, 50);
        }
    }
}
