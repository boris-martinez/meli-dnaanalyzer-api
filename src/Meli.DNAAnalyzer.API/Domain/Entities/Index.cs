using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Entities
{
    public class Index
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Index(int x, int y) {

            this.X = x;
            this.Y = y;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Index index = (Index)obj;
                return (this.X == index.X) && (this.Y == index.Y);
            }
        }

        public override int GetHashCode()
        {
            return (this.X << 2) ^ this.Y;
        }

        public Index Next(SequenceType sequenceType) {

            switch (sequenceType)
            {

                case SequenceType.HORIZONTAL:
                    return new Index(this.X, this.Y + 1);
                case SequenceType.VERTICAL:
                    return new Index(this.X + 1, this.Y);
                case SequenceType.OBLIQUE_RIGHT:
                    return new Index(this.X + 1, this.Y + 1);
                case SequenceType.OBLIQUE_LEFT:
                    return new Index(this.X + 1, this.Y - 1);
                default:
                    throw new NotImplementedException("Sequence type not supported");

            }
        }
    }
}
