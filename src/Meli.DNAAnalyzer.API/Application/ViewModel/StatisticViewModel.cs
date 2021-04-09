using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Application.ViewModel
{
    public class StatisticViewModel
    {
        [JsonProperty("count_mutant_dna")]
        public long MutantCount { get; set; }

        [JsonProperty("count_human_dna")]
        public long NoMutantCount { get; set; }

        [JsonProperty("ratio")]
        public double Ratio { get; set; }
    }
}
