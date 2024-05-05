using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAplicationRtk.Domain.DTO.Subject;
using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Interfaces.Services;

namespace QuizAplicationRtk.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CreateTestController : ControllerBase
{
    private readonly ICreateSubjectServices _services;

    public CreateTestController(ICreateSubjectServices services)
    {
        _services = services;
    }

    [HttpPost]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<SubjectDto>> CreateSubject([FromBody] SubjectDto dto)
    {
        var response = await _services.CreateSubject(dto);
        if(response != null)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }

    [HttpGet(template:"subject/{Id}")]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<SubjectDto>> GetSubject(long Id)
    {
        var response = await _services.GetSubjectAsync(Id);
        if (response != null)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }
}
