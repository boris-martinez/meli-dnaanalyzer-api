using Meli.DNAAnalyzer.API.Domain.Contracts;
using Meli.DNAAnalyzer.API.Domain.Services;
using Meli.DNAAnalyzer.UnitTests.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Meli.DNAAnalyzer.UnitTests
{
    [TestClass]
    public class DnaAnalyzerServiceTest
    {
        private Mock<INotificationService> notificationServiceMock;
        private IDnaAnalyzerService dnaAnalyzerService;

        [TestInitialize]
        public void Initialize()
        {
            this.notificationServiceMock = new Mock<INotificationService>();
            this.dnaAnalyzerService = new DnaAnalyzerService(this.notificationServiceMock.Object);
        }

        [TestMethod]
        public void test_case_1()
        {
            //Given
            var dna = DnaFactory.BuildDna1();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void test_case_2()
        {
            //Given
            var dna = DnaFactory.BuildDna2();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void test_case_3()
        {
            //Given
            var dna = DnaFactory.BuildDna3();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void test_case_4()
        {
            //Given
            var dna = DnaFactory.BuildDna4();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void test_case_5()
        {
            //Given
            var dna = DnaFactory.BuildDna5();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void test_case_6()
        {
            //Given
            var dna = DnaFactory.BuildDna6();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void test_case_7()
        {
            //Given
            var dna = DnaFactory.BuildDna7();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void test_case_8()
        {
            //Given
            var dna = DnaFactory.BuildDna8();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_9()
        {
            //Given
            var dna = DnaFactory.BuildDna9();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_10()
        {
            //Given
            var dna = DnaFactory.BuildDna10();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_11()
        {
            //Given
            var dna = DnaFactory.BuildDna11();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_12()
        {
            //Given
            var dna = DnaFactory.BuildDna12();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_13()
        {
            //Given
            var dna = DnaFactory.BuildDna13();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_14()
        {
            //Given
            var dna = DnaFactory.BuildDna14();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_15()
        {
            //Given
            var dna = DnaFactory.BuildDna15();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_16()
        {
            //Given
            var dna = DnaFactory.BuildDna16();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }




        [TestMethod]
        public void test_case_17()
        {
            //Given
            var dna = DnaFactory.BuildDna17();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_18()
        {
            //Given
            var dna = DnaFactory.BuildDna18();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }



        [TestMethod]
        public void test_case_19()
        {
            //Given
            var dna = DnaFactory.BuildDna19();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void test_case_20()
        {
            //Given
            var dna = DnaFactory.BuildDna20();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void test_case_21()
        {
            //Given
            var dna = DnaFactory.BuildDna21();

            //When
            var actual = this.dnaAnalyzerService.IsMutant(dna).Result;

            //Then
            Assert.IsTrue(actual);
        }
    }
}