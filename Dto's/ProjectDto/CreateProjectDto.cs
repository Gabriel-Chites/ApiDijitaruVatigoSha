using System.ComponentModel.DataAnnotations;
using TreinandoCodinDojo.Models;
using TreinandoCodinDojo.Models.Enums;

namespace TreinandoCodinDojo.Dto_s.ProjectDto;

public class CreateProjectDto
{
    [Required]
    [StringLength(50, ErrorMessage = "O campo de nome não suporta mais de 70 caracteres.")]
    public string Name { get; set; }

    [Required]
    public decimal Budget { get; set; }

    [Required]
    public ProjectType ProjectType { get; set; }
}
