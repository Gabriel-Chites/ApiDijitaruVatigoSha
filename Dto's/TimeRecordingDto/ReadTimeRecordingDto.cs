using System.ComponentModel.DataAnnotations;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Dto_s.TimeRecordingDto;

public class ReadTimeRecordingDto
{
    public int Id { get; set; }

    public int CollaboratorId { get; set; }

    public int ProjectId { get; set; }

    public int WorkingHours { get; set; }

    public bool IsApproved { get; set; } = false;
}
