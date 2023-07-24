using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TreinandoCodinDojo.Data;
using TreinandoCodinDojo.Dto_s.TimeRecordingDto;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeRecordingController: ControllerBase
{
    private CodinContext _context;
    private IMapper  _mapper;

    public TimeRecordingController(CodinContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult AddTimeRecording([FromBody] CreateTimeRecordingDto recordDto)
    {
        var recording = _mapper.Map<TimeRecording>(recordDto);
        if (recording == null) return NotFound();
        _context.Records.Add(recording);

        var project = _context.Projects.FirstOrDefault(p => p.id == recordDto.ProjectId);
        if (project == null) return NotFound();
        var collaborator = _context.Collaborators.FirstOrDefault(c => c.Id == recordDto.CollaboratorId);
        if (collaborator == null) return NotFound();

        project.RegisteredHours.Add(recording);
        collaborator.RegisteredHours.Add(recording);

        _context.SaveChanges();
        return Ok();
    }

    [HttpGet]

    public IEnumerable<ReadTimeRecordingDto> GetAllTimeRecording()
    {
        return _mapper.Map<List<ReadTimeRecordingDto>>(_context.Records.ToList());
    }
}
