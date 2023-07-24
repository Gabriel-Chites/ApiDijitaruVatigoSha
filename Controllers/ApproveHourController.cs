using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TreinandoCodinDojo.Data;
using TreinandoCodinDojo.Dto_s.ApproveHourDto;

namespace TreinandoCodinDojo.Controllers;

[ApiController]
[Route("[controller]")]
public class ApproveHourController : ControllerBase
{
    private CodinContext _context;
    private IMapper _mapper;

    public ApproveHourController(CodinContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]

    public IActionResult ApproveHour([FromQuery] int recordId, [FromQuery] int collaboratorId)
    {
        var collaborator = _context.Collaborators.FirstOrDefault(c => c.Id == collaboratorId);
        if (collaborator == null) return NotFound();


        var record = _context.Records.FirstOrDefault(r => r.Id == recordId);
        if (record == null) return NotFound();

        if (collaborator.Role == Models.Enums.RoleType.Normal) return BadRequest();

        record.IsApproved = true;

        _context.SaveChanges();

        return Ok();
    }
}
