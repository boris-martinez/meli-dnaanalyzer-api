using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Dto;
using Meli.DNAAnalyzer.API.Domain.Entities;
using Meli.DNAAnalyzer.API.Infraestructure.Exceptions;
using Microsoft.Extensions.Options;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskStatus = System.Threading.Tasks.TaskStatus;

namespace Meli.DNAAnalyzer.API.Infraestructure.Adapters.Persistance
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly ElasticClient elasticClient;

        public StatisticRepository(IOptions<ApplicationSettings> settings) {

            ApplicationSettings _settings = settings?.Value ?? throw new ArgumentNullException(nameof(settings));
            
            var ConnectionSettings = new ConnectionSettings(new Uri(_settings.ElasticsearchSettings.Uri))
                .DefaultIndex(_settings.ElasticsearchSettings.DnaStatisticsIndex)
                .BasicAuthentication(_settings.ElasticsearchSettings.Username, _settings.ElasticsearchSettings.Password);

            this.elasticClient = new ElasticClient(ConnectionSettings);
        }

        private async Task<long> CountDnaResults(bool isMutant)
        {
            var result = await this.elasticClient.CountAsync<dynamic>(c => c
                                .Index("")
                                .Query(q => q
                                    .Terms(m => m
                                        .Field(new Field("IsMutant"))
                                        .Terms(isMutant)
                                ))
                                );

            if (result.IsValid)
                return result.Count;
            else
                throw new InfraestructureException("It's not possible to query dna analyzer statistics",result.OriginalException);

        }
        public async Task<Statistic> Get()
        {
            var mutantCountTask = this.CountDnaResults(true);
            var NoMutantCountTask = this.CountDnaResults(false);
            long[] results  = await Task.WhenAll(mutantCountTask, NoMutantCountTask);

            return new Statistic(results[0],results[1]);
        }
    }
}
