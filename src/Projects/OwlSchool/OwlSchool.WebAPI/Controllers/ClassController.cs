using OwlSchool.Application.Features.Classes.Commands.CreateClass;
using OwlSchool.Application.Features.Classes.Dtos;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OwlSchool.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassController : BaseController
{
    [Route("AddClass")]
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateClassCommand createClassCommand)
    {
        CreatedClassDto result = await Mediator.Send(createClassCommand);
        return Created("", result);
    }
}