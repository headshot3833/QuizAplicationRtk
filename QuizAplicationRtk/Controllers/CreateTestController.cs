using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAplicationRtk.Domain.DTO.Subject;
using QuizAplicationRtk.Domain.DTO.Test;
using QuizAplicationRtk.Domain.Interfaces.Services;

namespace QuizAplicationRtk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateTestController : ControllerBase
    {
        private readonly ICreateTestService _services;

        public CreateTestController(ICreateTestService services)
        {
            _services = services;
        }


        [HttpPost]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CreateTestDto>> CreateTest([FromBody] CreateTestDto dto)
        {
            var response = await _services.CreateTestAsync(dto);
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
