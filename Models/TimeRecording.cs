using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TreinandoCodinDojo.Models;

public class TimeRecording
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int CollaboratorId { get; set; }

    [JsonIgnore]
    public virtual Collaborator Collaborator { get; set; }

    [Required]
    public int ProjectId { get; set; }

    [JsonIgnore]
    public virtual Project Project { get; set; }

    [Required]
    public int WorkingHours { get; set; }

    public bool IsApproved { get; set; } = false;
}
