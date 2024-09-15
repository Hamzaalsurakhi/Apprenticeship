using Apprenticeship.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Apprenticeship.Data
{
    public class ApplicationDbContext : IdentityDbContext<Person>
    {
        public DbSet<Student> students { get; set; }
        public DbSet<TeamLeader> teamLeaders { get; set; }
        public DbSet<SchoolSupervisor> schoolSupervisors { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Objective> objectives { get; set; }
        public DbSet<ReportStatus> reportStatuses { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Traning> tranings { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<Assignment> assignments { get; set; }
        public DbSet<School> schools { get; set; }
        public DbSet<TraningObjective> traningObjectives { get; set; }
        public DbSet<ObjectiveSkills> objectiveSkills { get; set; }
        public DbSet<AssignmentObjective> assignmentObjectives { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Traning>().HasKey(x =>x.TraningId);
            builder.Entity<ObjectiveSkills>().HasKey(x => new {x.objectiveId,x.skillId});
            builder.Entity<TraningObjective>().HasKey(x => new { x.traningId, x.objectiveId });
            builder.Entity<AssignmentObjective>().HasKey(x => new { x.assignmentId, x.objectiveId });


            base.OnModelCreating(builder);
        }
    }
}
