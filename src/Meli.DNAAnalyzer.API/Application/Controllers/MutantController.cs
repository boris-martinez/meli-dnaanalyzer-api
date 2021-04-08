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

        public MutantController(ILogger<MutantController> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
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
        public async Task<ActionResult> DetectMutant([FromBody] List<string> dna)
        {
            return Ok();
        }
    }
}
