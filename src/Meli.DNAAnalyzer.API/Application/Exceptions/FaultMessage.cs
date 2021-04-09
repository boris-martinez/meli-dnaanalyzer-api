using System;

namespace Meli.DNAAnalyzer.API.Application.Exceptions
{
    public class FaultMessage
    {
        public string Message { set; get; }

        public string Path { set; get; }

        public DateTime CreatedDate {get;set;}

    }
}
