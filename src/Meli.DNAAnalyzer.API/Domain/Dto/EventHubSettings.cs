using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Dto
{
    public class EventHubSettings
    {
        public string ConnectionString { get; set; }
        public string EventHubName { get; set; }
    }
}
