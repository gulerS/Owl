using Core.Application.Requests;
using OwlSchool.Application.Features.Classes.Commands.CreateClass;
using OwlSchool.Application.Features.Classes.Dtos;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OwlSchool.Application.Features.Classes.Models;
using OwlSchool.Application.Features.Classes.Queries.GetByIdClass;
using OwlSchool.Application.Features.Classes.Queries.GetListClass;

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

    [HttpGet("GetClassList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListClassQuery getListClassQuery = new() {PageRequest = pageRequest};
        ClassListModel result = await Mediator.Send(getListClassQuery);
        return Ok(result);
    }

    [HttpGet("GetClass/{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdClassQuery getByIdIdClassQuery)
    {
        ClassGetByIdDto classGetByIdDto = await Mediator.Send(getByIdIdClassQuery);
        return Ok(classGetByIdDto);
    }
}