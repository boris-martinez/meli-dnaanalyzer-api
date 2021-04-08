using Meli.DNAAnalyzer.API.Application.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Net;

namespace Meli.DNAAnalyzer.API.Application.Filters
{
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<HttpGlobalExceptionFilter> logger;

        public HttpGlobalExceptionFilter(ILogger<HttpGlobalExceptionFilter> logger)
        {
            this.logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            logger.LogError(new EventId(context.Exception.HResult),
                context.Exception,
                context.Exception.Message);


            var faultMessage = new FaultMessage()
            {
                Message = context.Exception.ToString(),
                Path = context.HttpContext.Request.Path,
                InnerCode = "ERR03"
            };

            context.Result = new ErrorObjectResult(faultMessage);
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.ExceptionHandled = true;
        }

        public class ErrorObjectResult : ObjectResult
        {
            public ErrorObjectResult(object error)
                : base(error) {}
        }
    }
}
