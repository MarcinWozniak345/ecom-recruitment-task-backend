using Backend.Application.Models;
using Backend.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpDelete("DeleteFootballer/{guid}")]
        public async Task<ActionResult> DeleteFootballer(Guid guid)
        {
            await _footballerService.DeleteFootballer(guid);
            return NoContent();
        }

        [HttpPost("CreateNewFootballer")]
        public async Task<ActionResult> CreateNewFootballer([FromBody] CreateFootbalerDTO newFootballer)
        {
            var data = _footballerService.GetAllFootballers();
            var exist = data.Any(x => x.Number == newFootballer.Number);
            if (exist)
            {
                return BadRequest(new { message = "istnieje już piłarz o takim numerze na koszulce" });
            }
            await _footballerService.CreateFootballer(newFootballer);
            return Ok(new { message = "Piłkarz został pomyślnie dodany." });

        }

        [HttpPut("UpdateFootballer")]
        public async Task<ActionResult> UpdateFootballer([FromBody] UpdateFootbalerDTO updatedFootballer)
        {
            var data = _footballerService.GetAllFootballers();
            var exist = data.Any(x => x.Number == updatedFootballer.Number && x.Guid != updatedFootballer.Guid);
            if (exist)
            {
                return BadRequest(new { message = "istnieje już piłarz o takim numerze na koszulce" });
            }
            await _footballerService.UpdateFootballer(updatedFootballer);
            return Ok(new { message = "Piłkarz został pomyślnie zmodyfikowany." }); ;
        }


    }
}
