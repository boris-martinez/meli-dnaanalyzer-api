using Meli.DNAAnalyzer.API.Application.Dto.Command;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Meli.DNAAnalyzer.IntegrationTests
{
   
    public class DnaAnalyzerTest: DnaAnalyzerTestBase
    {
        [Fact]
        public async Task detect_mutant_test()
        {
            using (var server = CreateServer())
            {
                var content = new StringContent(BuildMutantDna(), UTF8Encoding.UTF8, "application/json");
                var response = await server.CreateClient()
                    .PostAsync(Post.DetectMutant, content);

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }

        [Fact]
        public async Task detect_nomutant_test()
        {
            using (var server = CreateServer())
            {
                var content = new StringContent(BuildNoMutantDna(), UTF8Encoding.UTF8, "application/json");
                var response = await server.CreateClient()
                    .PostAsync(Post.DetectMutant, content);

                Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
            }
        }

        [Fact]
        public async Task get_statistics_test()
        {
            using (var server = CreateServer())
            {
                var response = await server.CreateClient()
                    .GetAsync(Get.GetStatistics);

                response.EnsureSuccessStatusCode();
            }
        }

        string BuildNoMutantDna()
        {
            var validateDnaCommand = new ValidateDnaCommand { Dna = new List<string> { "ATCG", "AGTC", "ATCG", "AGTC" } };
            return JsonConvert.SerializeObject(validateDnaCommand);
        }

        string BuildMutantDna()
        {
            var validateDnaCommand = new ValidateDnaCommand { Dna = new List<string> { "ATCGATCGGG", "AGTCAGTCCC", "ATCGATCGGG", "AGTCCGTCCC", "AAAAATCGGG", "AGTCAGTCCC", "ATCGATCGGG", "AGTCCGTCCC", "CGTCCGTCCC", "GGTCCGTCCC" } };
            return JsonConvert.SerializeObject(validateDnaCommand);
        }
    }
}
