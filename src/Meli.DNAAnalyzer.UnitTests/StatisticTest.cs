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
        public void get_ratio_when_mutantcount_greather_than_nomutantcount_test()
        {
            //Given
            long mutantCount = 100;
            long noMutantCount = 40;

            //When
            Statistic statistic = new Statistic(mutantCount, noMutantCount);
            double? actual = statistic.GetRatio();

            //Then
            Assert.AreEqual(2.5, actual);
        }

        [TestMethod]
        public void get_ratio_when_nomutantcount_greather_than_mutantcount_test()
        {
            //Given
            long mutantCount = 40;
            long noMutantCount = 100;

            //When
            Statistic statistic = new Statistic(mutantCount, noMutantCount);
            double? actual = statistic.GetRatio();

            //Then
            Assert.AreEqual(0.4, actual);
        }

        [TestMethod]
        public void get_ratio_when_nomutantcount_equals_than_mutantcount_test()
        {
            //Given
            long mutantCount = 40;
            long noMutantCount = 40;

            //When
            Statistic statistic = new Statistic(mutantCount, noMutantCount);
            double? actual = statistic.GetRatio();

            //Then
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void get_ratio_when_nomutantcount_equals_zero_test()
        {
            //Given
            long mutantCount = 40;
            long noMutantCount = 0;

            //When
            Statistic statistic = new Statistic(mutantCount, noMutantCount);
            double? actual = statistic.GetRatio();

            //Then
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void get_ratio_when_mutantcount_equals_zero_test()
        {
            //Given
            long mutantCount = 0;
            long noMutantCount = 100;

            //When
            Statistic statistic = new Statistic(mutantCount, noMutantCount);
            double? actual = statistic.GetRatio();

            //Then
            Assert.IsNull(actual);
        }
    }
}
