using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace experiment.Controllers
{
    [Authorize]
    [ApiController]
    [Route("temperature")]
    public class TemperatureController : ControllerBase
    {
        private readonly ILogger<TemperatureController> _logger;

        public TemperatureController(ILogger<TemperatureController> logger)
        {
            _logger = logger;
        }

        //[HttpPost("{sensorId}/temerature/{temperature}")]
        //public async Task<IActionResult> Š”atchSensorTestimony(
        //    [FromRoute] int sensorId,
        //    [FromRoute] double temperature)
        //{
             
        //}
    }
}