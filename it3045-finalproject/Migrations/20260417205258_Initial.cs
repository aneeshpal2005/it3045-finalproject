using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace it3045_finalproject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberBirthdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamMemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamMemberProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamMemberYear = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.TeamMemberId);
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "TeamMemberId", "TeamMemberBirthdate", "TeamMemberName", "TeamMemberProgram", "TeamMemberYear" },
                values: new object[,]
                {
                    { 1, "01/01/2005", "Aneesh Palande", "Game Development and Simulation", "Pre-Junior" },
                    { 2, "01/01/2005", "Alex Lauffenburger", "Cyber Security", "Pre-Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
