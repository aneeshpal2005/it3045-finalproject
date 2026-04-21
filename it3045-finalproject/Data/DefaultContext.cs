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
        public DbSet<Hobbies> Hobbies { get; set; }
        public DbSet<ChipotleMenu> ChipotleMenus { get; set; }
        public DbSet<MicrosoftServices> MicrosoftServices { get; set; }

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
            modelBuilder.Entity<Hobbies>().HasData(
                new Hobbies
                {
                    Id = 1,
                    Name = "Video Games",
                    Description = "Usually play in my free time",
                    HobbiesId = 1
                },
                new Hobbies
                {
                    Id = 2,
                    Name = "Cooking",
                    Description = "I like to cook in my free time",
                    HobbiesId= 2
                }
            );
            modelBuilder.Entity<ChipotleMenu>().HasData(
                new ChipotleMenu
                {
                    Id = 1,
                    Name = "Burrito",
                    Description = "A burrito is a type of Mexican food that consists of a flour tortilla wrapped around a filling, which can include various ingredients such as rice, beans, meat, cheese, and vegetables.",
                    ChipotleMenuId = 1
                },
                new ChipotleMenu
                {
                    Id = 2,
                    Name = "Bowl",
                    Description = "A bowl is a dish that consists of a base of rice or lettuce topped with various ingredients such as beans, meat, cheese, and vegetables. It is similar to a burrito but without the tortilla.",
                    ChipotleMenuId = 2
                }
            );
                modelBuilder.Entity<MicrosoftServices>().HasData(
                    new MicrosoftServices
                    {
                        Id = 1,
                        Name = "Azure",
                        Description = "Azure is a cloud computing platform and service created by Microsoft. It provides a wide range of cloud services, including those for computing, analytics, storage, and networking. Users can choose and configure these services to meet their specific needs.",
                        MicrosoftServicesId = 1
                    },
                    new MicrosoftServices
                    {
                        Id = 2,
                        Name = "Office 365",
                        Description = "Office 365 is a subscription-based service offered by Microsoft that provides access to a suite of productivity applications and services. It includes popular applications such as Word, Excel, PowerPoint, Outlook, and OneDrive, among others. Office 365 allows users to create, edit, and collaborate on documents in real-time from any device with an internet connection.",
                        MicrosoftServicesId = 2
                    }
                );


        }
    }

}
