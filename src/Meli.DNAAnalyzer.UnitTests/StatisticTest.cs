using Meli.DNAAnalyzer.API.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meli.DNAAnalyzer.UnitTests
{
    [TestClass]
    public class StatisticTest
    {
        [TestMethod]
        public void GetRatioTest()
        {
            //Given
            long mutantCount = 40;
            long noMutantCount = 100;

            //When
            Statistic statistic = new Statistic(mutantCount, noMutantCount);
            double actual = statistic.GetRatio();

            //Then
            Assert.AreEqual(0.4, actual);
        }
    }
}
