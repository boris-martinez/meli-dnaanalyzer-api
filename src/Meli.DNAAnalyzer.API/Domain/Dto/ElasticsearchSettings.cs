using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Dto
{
    public class ElasticsearchSettings
    {
        public string Uri { get; set; }
        public string DnaStatisticsIndex { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
