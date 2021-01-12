using Grpc.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Grpc.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        private readonly IMeteoriteService _meteoriteService;

        public CalculatorController(IMeteoriteService meteoriteService)
        {
            _meteoriteService = meteoriteService;
        }

        [HttpGet]
        public async Task<IActionResult> MeteoriteLandings()
        {
            return Ok(await _meteoriteService.GetMeteoriteLandings());
        }
    }
}
