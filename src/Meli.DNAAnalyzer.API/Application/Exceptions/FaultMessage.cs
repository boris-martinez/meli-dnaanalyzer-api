namespace Meli.DNAAnalyzer.API.Application.Exceptions
{
    public class FaultMessage
    {
        public string Message { set; get; }

        public string Path { set; get; }

        public string InnerCode { set; get; }

        public int HttpCode { set; get; }

    }
}
