using Meli.DNAAnalyzer.API.Application.ViewModel;
using Meli.DNAAnalyzer.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meli.DNAAnalyzer.API.Application.Translator
{
    public class StatisticViewModelMapper
    {

        protected StatisticViewModelMapper() { }

        public static StatisticViewModel Map(Statistic statistic)
        {
            return new StatisticViewModel()
            {
                MutantCount = statistic.MutantCount,
                NoMutantCount = statistic.NoMutantCount,
                Ratio = statistic.GetRatio()
            };
        }
    }
}
