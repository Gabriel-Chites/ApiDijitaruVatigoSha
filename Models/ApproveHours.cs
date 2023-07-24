using System.ComponentModel.DataAnnotations;

namespace TreinandoCodinDojo.Models;

public class ApproveHours
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int RecordId { get; set; }


}
