using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Entities
{
    public class Statistic
    {
        public long MutantCount { get; private set; }
        public long NoMutantCount { get; private set; }

        public Statistic(long mutantCount, long NoMutantCount) {

            this.MutantCount = mutantCount;
            this.NoMutantCount = NoMutantCount;
        }

        public double GetRatio()
        {
            //todo: Calcular ratio
            double ratio = 0.4;
            return ratio;
        }
    }
}
