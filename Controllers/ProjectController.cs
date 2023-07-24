using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TreinandoCodinDojo.Data;
using TreinandoCodinDojo.Dto_s.CollaboratorDto;
using TreinandoCodinDojo.Dto_s.ProjectDto;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Controllers;

[ApiController]
[Route("[controller]")]

public class ProjectController: ControllerBase
{
    private CodinContext _context;
    private IMapper _mapper;

    public ProjectController(CodinContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddProject([FromBody] CreateProjectDto projectDto)
    {  
        var project = _mapper.Map<Project>(projectDto);
        _context.Projects.Add(project);
        _context.SaveChanges();
        return Ok();
    }



    [HttpPost("AddCollaboratorToProject/{id}")]
    public IActionResult AddCollaboratorToProject(int id, [FromBody] int collaboratorId)
    {
        var project = _context.Projects.FirstOrDefault(p => p.id == id);
        if(project == null) return NotFound();

        var collaborator = _context.Collaborators.FirstOrDefault(c => c.Id == collaboratorId);
        if(collaborator == null) return NotFound();

        project.Collaborators.Add(collaborator);
        _context.SaveChanges();

        return Ok();
    }

    //[HttpPost("AddApproverToProject/{id}")]
    //public IActionResult AddApproverToProject(int id, [FromBody] int collaboratorId)
    //{
    //    var project = _context.Projects.FirstOrDefault(p => p.id == id);
    //    if (project == null) return NotFound();

    //    var collaborator = _context.Collaborators.FirstOrDefault(c => c.Id == collaboratorId);
    //    if (collaborator == null || collaborator.Role == Models.Enums.RoleType.Normal) return BadRequest();

    //    project.Approvers.Add(collaborator);
    //    _context.SaveChanges();

    //    return Ok();
    //}

    [HttpGet]
    public IEnumerable<ReadProjectDto> GetProjects()
    {
        return _mapper.Map<IList<ReadProjectDto>>(_context.Projects.ToList());
    }
}
