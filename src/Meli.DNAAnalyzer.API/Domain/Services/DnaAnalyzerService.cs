using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Entities;
using Meli.DNAAnalyzer.API.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Domain.Services
{
    public class DnaAnalyzerService : IDnaAnalyzerService
    {
        private readonly INotificationService notificationService;

        public DnaAnalyzerService(INotificationService notificationService) {

            this.notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
        }

        public async Task<bool> AnalyzeDna(List<string> dna)
        {
            bool isMutant = this.IsMutant(dna);
            await this.notificationService.Notify(new HumanVerifiedDomainEvent(dna, isMutant));
            return isMutant;
        }

        private bool IsMutant(List<string> dna)
        {
            bool mutantFound = false;
            short sequenceCount = 0;
            Sequence lastSequenceFound = null;
            Sequence sequence = null;
            Entities.Index index = null;

            Matrix matrix = new Matrix(dna);

            if (matrix.RowsCount < 4 && matrix.ColumnsCount < 4)
                return false;

            for (int x = 0; x < matrix.RowsCount; x++)
            {
                for (int y = 0; y < matrix.ColumnsCount; y++)
                {

                   index = new Entities.Index(x, y);

                    if (!this.IndexBelongToHorizontalSequence(lastSequenceFound, index))
                    {
                        sequence = matrix.FindHorizontalSequence(index);
                        this.AnalyzeResult(sequence, ref sequenceCount, ref lastSequenceFound, out mutantFound);
                        if (mutantFound)
                            return true;
                    }

                    if (!this.IndexBelongToVerticalSequence(lastSequenceFound, index))
                    {
                        sequence = matrix.FindVerticalSequence(index);
                        this.AnalyzeResult(sequence, ref sequenceCount, ref lastSequenceFound, out mutantFound);
                        if (mutantFound)
                            return true;
                    }

                    if (!this.IndexBelongToLeftObliqueSequence(lastSequenceFound, index))
                    {
                        sequence = matrix.FindLeftObliqueSequence(index);
                        this.AnalyzeResult(sequence, ref sequenceCount, ref lastSequenceFound, out mutantFound);
                        if (mutantFound)
                            return true;
                    }

                    if (!this.IndexBelongToRightObliqueSequence(lastSequenceFound, index))
                    {
                        sequence = matrix.FindRightObliqueSequence(index);
                        this.AnalyzeResult(sequence, ref sequenceCount, ref lastSequenceFound, out mutantFound);
                        if (mutantFound)
                            return true;
                    }
                }
            }

            return false;
        }

        private void AnalyzeResult(Sequence result, ref short sequenceCount, ref Sequence lastSequenceFound, out bool mutantFound) {

            mutantFound = false;

            if (result != null)
            {
                if (lastSequenceFound != null)
                    mutantFound = true;
                else
                {
                    ++sequenceCount;
                    lastSequenceFound = result;
                }
            }
        }

        private bool IndexBelongToHorizontalSequence(Sequence sequence, Entities.Index index) {

            return sequence!=null && sequence.SequenceType == SequenceType.HORIZONTAL && sequence.Contains(index);
        }

        private bool IndexBelongToVerticalSequence(Sequence sequence, Entities.Index index)
        {
            return sequence != null && sequence.SequenceType == SequenceType.VERTICAL && sequence.Contains(index);
        }

        private bool IndexBelongToLeftObliqueSequence(Sequence sequence, Entities.Index index)
        {
            return sequence != null && sequence.SequenceType == SequenceType.OBLIQUE_LEFT&&  sequence.Contains(index) ;
        }

        private bool IndexBelongToRightObliqueSequence(Sequence sequence, Entities.Index index)
        {
            return sequence != null && sequence.SequenceType == SequenceType.OBLIQUE_RIGHT && sequence.Contains(index);
        }

    }
}
