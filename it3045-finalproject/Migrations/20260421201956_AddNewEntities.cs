using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace it3045_finalproject.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChipotleMenus",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipotleMenus", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HobbiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MicrosoftServices",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicrosoftServices", x => x.ServiceId);
                });

            migrationBuilder.InsertData(
                table: "ChipotleMenus",
                columns: new[] { "ItemId", "Description", "ItemCost", "ItemName", "ItemType" },
                values: new object[,]
                {
                    { 1, "A burrito is a type of Mexican food that consists of a flour tortilla wrapped around a filling, which can include various ingredients such as rice, beans, meat, cheese, and vegetables.", 10.0, "Burrito", "Entree" },
                    { 2, "A bowl is a dish that consists of a base of rice or lettuce topped with various ingredients such as beans, meat, cheese, and vegetables. It is similar to a burrito but without the tortilla.", 9.5, "Bowl", "Entree" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Description", "HobbiesId", "Name" },
                values: new object[,]
                {
                    { 1, "Usually play in my free time", 1, "Video Games" },
                    { 2, "I like to cook in my free time", 2, "Cooking" }
                });

            migrationBuilder.InsertData(
                table: "MicrosoftServices",
                columns: new[] { "ServiceId", "ServiceCategory", "ServiceDescription", "ServiceName", "SubscriptionCost" },
                values: new object[,]
                {
                    { 1, "Cloud Computing", "Azure is a cloud computing platform and service created by Microsoft. It provides a wide range of cloud services, including those for computing, analytics, storage, and networking. Users can choose and configure these services to meet their specific needs.", "Azure", 23.989999999999998 },
                    { 2, "Productivity", "Office 365 is a subscription-based service offered by Microsoft that provides access to a suite of productivity applications and services. It includes popular applications such as Word, Excel, PowerPoint, Outlook, and OneDrive, among others. Office 365 allows users to create, edit, and collaborate on documents in real-time from any device with an internet connection.", "Office 365", 12.99 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChipotleMenus");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "MicrosoftServices");
        }
    }
}
