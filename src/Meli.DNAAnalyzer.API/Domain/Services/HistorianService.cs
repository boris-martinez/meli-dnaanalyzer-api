using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Services
{
    public class HistorianService : IHistorianService
    {
        private readonly IStatisticRepository statisticRepository;

        public HistorianService(IStatisticRepository statisticRepository) {

            this.statisticRepository = statisticRepository ?? throw new ArgumentNullException(nameof(statisticRepository));
        }

        public async Task<Statistic> GetStatistics()
        {
            return await this.statisticRepository.Get();
        }
    }
}
