using System.ComponentModel.DataAnnotations;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Dto_s.TimeRecordingDto;

public class CreateTimeRecordingDto
{
    [Required]
    public int CollaboratorId { get; set; }

    [Required]
    public int ProjectId { get; set; }

    [Required]
    public int WorkingHours { get; set; }
}
