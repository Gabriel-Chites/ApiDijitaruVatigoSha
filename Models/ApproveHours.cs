using System.ComponentModel.DataAnnotations;

namespace TreinandoCodinDojo.Models;

public class ApproveHours
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int RecordId { get; set; }

    public virtual IList<TimeRecording> Records { get; set; }

    public virtual IList<Collaborator> Collaborators { get; set; }

    public ApproveHours()
    {
        Records = new List<TimeRecording>();
        Collaborators = new List<Collaborator>();
    }
}
