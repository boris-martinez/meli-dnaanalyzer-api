using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Entities
{
    public class Matrix
    {
        private const short MAX_OCURRENCES = 4;
        private const short INDEX_FIRST_COLUMN = 0;
        public string[,] BidimensionalArray { get; private set; }
        public int RowsCount { get; private set; }
        public int ColumnsCount { get; private set; }

        public Matrix(List<string> values)
        {
            this.Parse(values);
        }

        private void Parse(List<string> values) {

            if (values.Count == 0)
                throw new ArgumentException("Input values must be greather than zero");

            int rows = values.Count;
            int columns = values[0].Length;

            if(rows!=columns)
                throw new ArgumentException("Matrix must be NXN");

            this.BidimensionalArray = new string[rows,columns];
            this.RowsCount = rows;
            this.ColumnsCount = columns;

            for(int x=0;x<values.Count;x++)
            {
                if (values[x].Length == columns)
                {
                    for (int y = 0; y < values[x].Length; y++) {

                        this.BidimensionalArray[x, y] = values[x][y].ToString();
                    }
                }
                else 
                    throw new ArgumentException("All values must contains the same quantity of chars");
            }
        }

        private void FindSequence(Index index, string value, ref List<Index> ocurrences, SequenceType sequenceType)
        {

            if (this.BidimensionalArray[index.X, index.Y] == value)
            {
                ocurrences.Add(index);
                if (ocurrences.Count < MAX_OCURRENCES)
                    this.FindSequence(index.Next(sequenceType), value, ref ocurrences, sequenceType);
            }
        }


        public Sequence FindHorizontalSequence(Index index)
        {

            if (index.Y + MAX_OCURRENCES <= this.ColumnsCount)
            {
                List<Index> ocurrences = new List<Index>();
                this.FindSequence(index, this.BidimensionalArray[index.X, index.Y], ref ocurrences, SequenceType.HORIZONTAL);
                if (ocurrences.Count == MAX_OCURRENCES)
                    return new Sequence(ocurrences, SequenceType.HORIZONTAL);
            }

            return null;
        }

        public Sequence FindVerticalSequence(Index index)
        {

            if (index.X + MAX_OCURRENCES <= this.RowsCount)
            {
                List<Index> ocurrences = new List<Index>();
                this.FindSequence(index, this.BidimensionalArray[index.X, index.Y], ref ocurrences, SequenceType.VERTICAL);
                if (ocurrences.Count == MAX_OCURRENCES)
                    return new Sequence(ocurrences, SequenceType.VERTICAL);
            }

            return null;
        }

        public Sequence FindRightObliqueSequence(Index index)
        {

            if (index.X + MAX_OCURRENCES <= this.RowsCount && index.Y+MAX_OCURRENCES <= this.ColumnsCount)
            {
                List<Index> ocurrences = new List<Index>();
                this.FindSequence(index, this.BidimensionalArray[index.X, index.Y], ref ocurrences, SequenceType.OBLIQUE_RIGHT);
                if (ocurrences.Count == MAX_OCURRENCES)
                    return new Sequence(ocurrences, SequenceType.OBLIQUE_RIGHT);
            }

            return null;
        }

        public Sequence FindLeftObliqueSequence(Index index)
        {

            if (index.X + MAX_OCURRENCES <= this.RowsCount && (index.Y+1) - MAX_OCURRENCES >= INDEX_FIRST_COLUMN)
            {
                List<Index> ocurrences = new List<Index>();
                this.FindSequence(index, this.BidimensionalArray[index.X, index.Y], ref ocurrences, SequenceType.OBLIQUE_LEFT);
                if (ocurrences.Count == MAX_OCURRENCES)
                    return new Sequence(ocurrences, SequenceType.OBLIQUE_LEFT);
            }

            return null;
        }
    }
}
