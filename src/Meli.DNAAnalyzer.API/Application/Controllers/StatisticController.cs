using Meli.DNAAnalyzer.API.Application.Translator;
using Meli.DNAAnalyzer.API.Application.ViewModel;
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
    public class StatisticController: ControllerBase
    {

        private readonly ILogger<StatisticController> logger;
        private readonly IHistorianService historianService;

        public StatisticController(ILogger<StatisticController> logger, IHistorianService historianService)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.historianService = historianService ?? throw new ArgumentNullException(nameof(historianService));
        }

        /// <summary>
        /// Consulta las estadisticas de las verificaciones ADN
        /// </summary>
        ///<returns>Estadísticas</returns>
        [Route("stats")]
        [HttpGet]
        [ProducesResponseType(typeof(StatisticViewModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<StatisticViewModel>> GetStatistics()
        {
            var statistic = await this.historianService.GetStatistics();
            return Ok(StatisticViewModelMapper.Map(statistic));
        }
    }
}
