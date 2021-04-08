using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Text.RegularExpressions;

namespace Meli.DNAAnalyzer.API.Application.Filters
{
    public class TelemetryFilterProcessor : ITelemetryProcessor
    {
        private ITelemetryProcessor Next { get; set; }
        private const string PATTERN = @"\/api\/v";

        public TelemetryFilterProcessor(ITelemetryProcessor next)
        {
            this.Next = next;
        }

        private bool IsValidEndpoint(String value)
        {
            Match match = Regex.Match(value, PATTERN);
            return match.Success;

        }

        public void Process(ITelemetry item)
        {
            if ((item is RequestTelemetry request) && (!this.IsValidEndpoint(request.Url.AbsolutePath)))
            {
                return;
            }

            this.Next.Process(item);
        }
    }
}
