using Microsoft.EntityFrameworkCore;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Data
{
    public class CodinContext: DbContext
    {
        public CodinContext(DbContextOptions<CodinContext> opts)
            : base(opts)
        {
        
        }

        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeRecording> Records { get; set; }
        public DbSet<ApproveHours> ApproveHours { get; set; }

    }
}
