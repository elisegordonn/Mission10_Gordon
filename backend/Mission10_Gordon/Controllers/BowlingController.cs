using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Gordon.Data;

namespace Mission10_Gordon.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlRepository;
        public BowlingController(IBowlingRepository temp)
        {
            _bowlRepository = temp;
        }
        [HttpGet("marlins-sharks")]
        public IActionResult GetMarlinsSharks()
        {
            var bowlData = _bowlRepository.GetMarlinsSharks();
            return Ok(bowlData);
        }
    }
}
