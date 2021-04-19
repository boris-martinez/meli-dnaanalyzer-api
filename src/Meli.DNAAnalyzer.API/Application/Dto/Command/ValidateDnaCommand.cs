using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Application.Dto.Command
{
    public class ValidateDnaCommand
    {
        [JsonProperty("dna")]
        public List<string> Dna { get; set; }
    }
}
