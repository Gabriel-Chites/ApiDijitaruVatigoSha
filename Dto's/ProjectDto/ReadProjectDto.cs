using System.ComponentModel.DataAnnotations;
using TreinandoCodinDojo.Models.Enums;
using TreinandoCodinDojo.Models;
using System.Text.Json.Serialization;

namespace TreinandoCodinDojo.Dto_s.ProjectDto;

public class ReadProjectDto
{  
    public string Name { get; set; }

    public decimal Budget { get; set; }

    public ProjectType ProjectType { get; set; }

    public List<Collaborator> Collaborators { get; set; }

    public List<TimeRecording> RegisteredHours { get; set; }
}
