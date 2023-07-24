using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TreinandoCodinDojo.Models.Enums;

namespace TreinandoCodinDojo.Models;

public class Collaborator
{
    [Key]
    [Required]
    public int  Id { get; set; }

    [Required]
    [StringLength(70, ErrorMessage = "O campo de nome não aceita mais de 70 caracteres!")]
    public string Name { get; set; }

    [Required]
    public char Gender{ get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    public HiringModality Modality { get; set; }

    [Required]
    public RoleType Role { get; set; }

    [JsonIgnore]
    public virtual List<Project> Projects { get; set; }

    public virtual List<TimeRecording> RegisteredHours { get; set; }

    public Collaborator()
    {
       Projects = new List<Project>();
       RegisteredHours = new List<TimeRecording>();
    }
}
