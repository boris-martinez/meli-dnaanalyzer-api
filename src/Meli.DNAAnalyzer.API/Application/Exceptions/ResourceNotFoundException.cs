using System;
using System.Runtime.Serialization;

namespace Meli.DNAAnalyzer.API.Application.Exceptions
{
    [Serializable]
    public class ResourceNotFoundException : System.Exception
    {
        public ResourceNotFoundException(string message) : base(message)
        { }
        public ResourceNotFoundException(string message, System.Exception ex) : base(message, ex)
        { }
        protected ResourceNotFoundException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        { }
    }
}
