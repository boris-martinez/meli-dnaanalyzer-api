using Meli.DNAAnalyzer.API;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meli.DNAAnalyzer.IntegrationTests
{
    public class DnaAnalyzerTestsStartup : Startup
    {
        public DnaAnalyzerTestsStartup(IConfiguration env) : base(env)
        {
        }
    }
}
