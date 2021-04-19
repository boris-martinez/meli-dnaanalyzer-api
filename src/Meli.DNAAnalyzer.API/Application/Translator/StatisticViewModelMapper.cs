using Meli.DNAAnalyzer.API.Application.Dto.ViewModel;
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
            StatisticViewModel statisticViewModel = new StatisticViewModel()
            {
                MutantCount = statistic.MutantCount,
                NoMutantCount = statistic.NoMutantCount
            };

            double? ratio = statistic.GetRatio();

            if (ratio.HasValue)
                statisticViewModel.Ratio = Math.Round(ratio.Value, 1);

            return statisticViewModel;
        }
    }
}
