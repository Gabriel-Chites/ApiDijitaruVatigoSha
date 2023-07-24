using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TreinandoCodinDojo.Data;
using TreinandoCodinDojo.Dto_s.CollaboratorDto;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Controllers;

[ApiController]
[Route("[controller]")]

public class CollaboratorController : ControllerBase
{
    private CodinContext _context;
    private IMapper _mapper;

    public CollaboratorController(CodinContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult AddCollaborator([FromBody]CreateCollaboratorDto collaboratorDto)
    {
        var collaborator = _mapper.Map<Collaborator>(collaboratorDto);
        _context.Collaborators.Add(collaborator);
        _context.SaveChanges();
        return Ok();
    }


    [HttpGet]

    public IEnumerable<ReadCollaboratorDto> GetReadCollaborator()
    {
        return _mapper.Map<List<ReadCollaboratorDto>>(_context.Collaborators.ToList());
    }
}
