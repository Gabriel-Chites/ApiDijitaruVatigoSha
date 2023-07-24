using System.ComponentModel.DataAnnotations;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Dto_s.ApproveHourDto;

public class CreateApproveHourDto
{
    [Required]
    public int RecordId { get; set; }

    public virtual IList<TimeRecording> Records { get; set; }

    public virtual IList<Collaborator> Collaborators { get; set; }
}
