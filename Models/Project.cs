using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TreinandoCodinDojo.Models.Enums;

namespace TreinandoCodinDojo.Models;

public class Project
{
    [Key]
    [Required]
    public int id { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "O campo de nome não suporta mais de 70 caracteres.")]
    public string Name { get; set; }

    [Required]
    public decimal Budget { get; set; }

    [Required]
    public ProjectType ProjectType { get; set; }

    [JsonIgnore]
    public virtual IList<Collaborator> Collaborators { get; set; }

    public virtual IList<TimeRecording> RegisteredHours{ get; set; }

    public Project()
    {
        Collaborators = new List<Collaborator>();
        RegisteredHours = new List<TimeRecording>();
    }
}
