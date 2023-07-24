using System.ComponentModel.DataAnnotations;
using TreinandoCodinDojo.Models.Enums;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Dto_s.CollaboratorDto;

public class CreateCollaboratorDto
{
    [Required]
    [StringLength(70, ErrorMessage = "O campo de nome não aceita mais de 70 caracteres!")]
    public string Name { get; set; }

    [Required]
    public char Gender { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    public HiringModality Modality { get; set; }

    [Required]
    public RoleType Role { get; set; }
}
