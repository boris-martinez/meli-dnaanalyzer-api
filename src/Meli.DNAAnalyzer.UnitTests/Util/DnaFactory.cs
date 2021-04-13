using System;
using System.Collections.Generic;
using System.Text;

namespace Meli.DNAAnalyzer.UnitTests.Util
{
    public class DnaFactory
    {

        protected DnaFactory() { }

        public static List<string> BuildDna1() { 
        
            return new List<string> { "ATCG","AGTC","ATCG","AGTC" };
        }

        public static List<string> BuildDna2()
        {

            return new List<string> { "ATCG","CACG","CTAG","CTCA" };
        }

        public static List<string> BuildDna3()
        {

            return new List<string> {"TTCT","CGTG","CTGG","TTCC" };
        }

        public static List<string> BuildDna4()
        {

            return new List<string> { "TTCA","GGTA","TTCA","GGTA" };
        }

        public static List<string> BuildDna5()
        {

            return new List<string> { "ATCG","AGTC","ATCG","CGTC" };
        }

        public static List<string> BuildDna6()
        {

            return new List<string> { "ATCG", "CACG", "CTAG", "CTCC" };
        }

        public static List<string> BuildDna7()
        {

            return new List<string> { "AACT","AGTT","ATCT","AGTT" };
        }

        public static List<string> BuildDna8()
        {

            return new List<string> { "AAAA","GGTC","ATCG","AAAA" };
        }

        public static List<string> BuildDna9()
        {

            return new List<string> { "ATCA","CAAG","CAAG","ATCA" };
        }

        public static List<string> BuildDna10()
        {

            return new List<string> { "AAAA","AACG","ATAG","ATCC" };
        }

        public static List<string> BuildDna11()
        {

            return new List<string> { "AAAA","CTCA","CTAA","CTCA" };
        }

        public static List<string> BuildDna12()
        {

            return new List<string> { "ATCA","CTCA","CTAA","AAAA" };
        }

        public static List<string> BuildDna13()
        {

            return new List<string> { "TTCG","TACG","TTAG","TTTT" };
        }

        public static List<string> BuildDna14()
        {

            return new List<string> { "ATCG","CTCG","CTAG","TTTT" };
        }

        public static List<string> BuildDna15()
        {

            return new List<string> { "TTCT","TATG","TTAG","TTTT" };
        }

        public static List<string> BuildDna16()
        {

            return new List<string> { "ATCGATCGGG","AGTCAGTCCC","ATCGATCGGG","AGTCCGTCCC","ATCGATCGGG","AGTCAGTCCC","ATCGATAGGG","TGTCCGTCCC","CGTCCGTCCC","GGTCCGTCCC" };
        }

        public static List<string> BuildDna17()
        {

            return new List<string> { "ATCGATCGGG","GATCAGTCCC","CTAGATCGGG","CGTACGTCCC","ATCGATCGGG","AGTCAATCCC","ATCGATAGGG","TGTCCGTCCC","CGTCCGTCCC","GGTCCGTCCC" };
        }

        public static List<string> BuildDna18()
        {

            return new List<string> { "CTCGATCGGA","GTTCAGTCAC","CTGGATCAGG","CGTCCGACCC","ATCGAACGGG","AGTCAATCCC","ATCAATAGGG","TGTCCGTCCC","CGTCCGTCCC","GGTCCGTCCC" };
        }

        public static List<string> BuildDna19()
        {

            return new List<string> { "ATCGATCGGG","AGTCAGTCCC","ATCGATCGGG","AGTCCGTCCC","ATCGATCGGG","AGTCAGTCCC","ATCGATCGGG","AGTCCGTCCC","CGTCCGTCCC","GGTCCGTCCC" };
        }

        public static List<string> BuildDna20()
        {

            return new List<string> { "ATCGATCGGG","AGTCAGTCCC","ATCGATCGGG","AGTCCGTCCC","AAAAATCGGG","AGTCAGTCCC","ATCGATCGGG","AGTCCGTCCC","CGTCCGTCCC","GGTCCGTCCC" };
        }

        public static List<string> BuildDna21()
        {

            return new List<string> { "ATGCGTCGGG","TAACGGTCCC","GTAGGTCGGG","TGCAGGTCCC","CCCCATCGGG","AGTCAGTCCC","ATCGATCGGG","TGTCCGTCCC","CGTCCGTCCC","GGTCCGTCCC" };
        }

        public static List<string> BuildDna22()
        {

            return new List<string> { "ATC","AGT","ATC","AGT" };
        }

        public static List<string> BuildDna23()
        {

            return new List<string> { "ATC","AGT","ATC" };
        }

        public static List<string> BuildDna24()
        {

            return new List<string> { "BTCG", "AGTC", "ATCG", "AGTC" };
        }

        public static List<string> BuildDna25()
        {

            return new List<string> { "ATCTT","AGTCC","ATCAA","AGTAA" };
        }
    }
}
