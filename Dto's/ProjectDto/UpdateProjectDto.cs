using TreinandoCodinDojo.Models.Enums;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Dto_s.ProjectDto;

public class UpdateProjectDto
{
    public string Name { get; set; }

    public decimal Budget { get; set; }

    public ProjectType ProjectType { get; set; }

    public List<Collaborator> Collaborators { get; set; }
}
