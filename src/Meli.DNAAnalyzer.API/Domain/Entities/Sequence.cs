using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Entities
{
    public class Sequence
    {
        public List<Index> Indexes { get; private set; }
        public SequenceType SequenceType { get; private set; }

        public Sequence(List<Index> indexes, SequenceType SequenceType) {

            this.Indexes = indexes;
            this.SequenceType = SequenceType;
        }

        public bool Contains(Index index) {

            return this.Indexes.Contains(index) ;
        }
    }
}
