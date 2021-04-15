using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Dto
{
    [ExcludeFromCodeCoverage]
    public class ApplicationSettings
    {
        public EventHubSettings EventHubSettings { get; set; }
        public ElasticsearchSettings ElasticsearchSettings { get; set; }
    }
}
