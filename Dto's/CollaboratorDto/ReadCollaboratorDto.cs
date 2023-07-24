using System.ComponentModel.DataAnnotations;
using TreinandoCodinDojo.Models;
using TreinandoCodinDojo.Models.Enums;

namespace TreinandoCodinDojo.Dto_s.CollaboratorDto;

public class ReadCollaboratorDto
{
    public string Name { get; set; }

    public char Gender { get; set; }

    public DateTime BirthDate { get; set; }

    public HiringModality Modality { get; set; }

    public RoleType Role { get; set; }

    public virtual List<Project> Projects { get; set; }

    public virtual List<TimeRecording> TimeRecordings { get; set; }
}
