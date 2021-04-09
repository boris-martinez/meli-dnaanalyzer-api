using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Entities
{
    public class Result
    {
        public bool IsMutant { get; private set; }

        public Result(bool isMutant) {

            this.IsMutant = IsMutant;
        }
    }
}
