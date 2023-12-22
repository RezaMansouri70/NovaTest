using Application.Models.General;
using ApplicationServices.Services.DopingService;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DopingController : ControllerBase
    {
        private readonly IDopingService _dopingService;

        public DopingController(IDopingService dopingService)
        {
            _dopingService = dopingService;
        }

        [HttpGet("GetDopingGetList")]
        public async Task<IActionResult> GetDopingGetList([FromQuery] Filter filter, CancellationToken token)
        {
            return Ok(await _dopingService.GetList(filter, token));
        }
    }
}
