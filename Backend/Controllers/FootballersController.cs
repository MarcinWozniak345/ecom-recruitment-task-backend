using Backend.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/Footballers")]
    [ApiController]
    public class FootballersController : ControllerBase
    {
        private readonly IFootballerService _footballerService;
        public FootballersController(IFootballerService footballerService)
        {
            _footballerService = footballerService;
        }


        [HttpGet("GetAllFootballers")]
        public ActionResult GetAllFootballers()
        {
            return Ok(_footballerService.GetAllFootballers());
        }

        [HttpGet("GetFootballer/{guid}")]
        public ActionResult GetFootballers(Guid guid)
        {

            return Ok(_footballerService.GetFootballer(guid));
        }

    }
}
