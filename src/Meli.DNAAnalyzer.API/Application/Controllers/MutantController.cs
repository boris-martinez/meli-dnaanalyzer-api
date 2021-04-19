using Meli.DNAAnalyzer.API.Application.Dto.Command;
using Meli.DNAAnalyzer.API.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace Meli.DNAAnalyzer.API.Application.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class MutantController : ControllerBase
    {

        private readonly ILogger<MutantController> logger;
        private readonly IDnaAnalyzerService dnaAnalyzerService;

        public MutantController(ILogger<MutantController> logger, IDnaAnalyzerService dnaAnalyzerService)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.dnaAnalyzerService = dnaAnalyzerService ?? throw new ArgumentNullException(nameof(dnaAnalyzerService));
        }

        /// <summary>
        /// Detecta si un humano es mutante basandose en su secuencia de ADN
        /// </summary>
        /// <param name="dna">Secuencia de ADN</param>
        [Route("mutant")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        public async Task<ActionResult> DetectMutant([FromBody] ValidateDnaCommand validateDnaCommand)
        {
            bool isMutant = await this.dnaAnalyzerService.AnalyzeDna(validateDnaCommand.Dna);
            return isMutant ? StatusCode(200,String.Empty) : StatusCode(403, null);
        }
    }
}
