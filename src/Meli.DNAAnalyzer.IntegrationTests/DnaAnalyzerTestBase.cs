using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.TestHost;

namespace Meli.DNAAnalyzer.IntegrationTests
{
    public class DnaAnalyzerTestBase
    {
        public TestServer CreateServer()
        {
            var path = Assembly.GetAssembly(typeof(DnaAnalyzerTestBase))
                .Location;

            var hostBuilder = new WebHostBuilder()
                .UseContentRoot(Path.GetDirectoryName(path))
                .ConfigureAppConfiguration(cb =>
                {
                    cb.AddJsonFile("appsettings.json", optional: false)
                    .AddEnvironmentVariables();
                })
                .UseStartup<DnaAnalyzerTestsStartup>();

            var testServer = new TestServer(hostBuilder);

            return testServer;
        }

        public static class Get
        {
            public static string GetStatistics = "api/v1/stats";
        }

        public static class Post
        {
            public static string DetectMutant = "api/v1/mutant";
        }
    }
}
