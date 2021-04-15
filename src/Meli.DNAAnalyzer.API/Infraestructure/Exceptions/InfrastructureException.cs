using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Meli.DNAAnalyzer.API.Infraestructure.Exceptions
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class InfraestructureException : Exception
    {
        public InfraestructureException()
        { }
        public InfraestructureException(string message) : base(message)
        { }
        public InfraestructureException(string message, Exception ex) : base(message, ex)
        { }
        protected InfraestructureException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
