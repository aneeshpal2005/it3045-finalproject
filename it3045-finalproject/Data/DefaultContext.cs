using it3045_finalproject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace it3045_finalproject.Data

{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }
        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    TeamMemberId = 1,
                    TeamMemberBirthdate = "01/01/2005",
                    TeamMemberName = "Aneesh Palande",
                    TeamMemberProgram = "Game Development and Simulation",
                    TeamMemberYear = "Pre-Junior"
                },
                new TeamMember
                {
                    TeamMemberId = 2,
                    TeamMemberBirthdate = "01/01/2005",
                    TeamMemberName = "Alex Lauffenburger",
                    TeamMemberProgram = "Cyber Security",
                    TeamMemberYear = "Pre-Junior"
                }
            );


        }
    }

}
