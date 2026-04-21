using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace it3045_finalproject.Migrations
{
    /// <inheritdoc />
    public partial class NewEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChipotleMenus",
                columns: new[] { "ItemId", "Description", "ItemCost", "ItemName", "ItemType" },
                values: new object[,]
                {
                    { 3, "Soft or crispy tortillas filled with meat, salsa, and toppings.", 8.25, "Tacos", "Entree" },
                    { 4, "Grilled tortilla stuffed with cheese and optional fillings.", 7.75, "Quesadilla", "Entree" },
                    { 5, "Crispy chips served with fresh guacamole.", 3.5, "Chips & Guacamole", "Side" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Description", "HobbiesId", "Name" },
                values: new object[,]
                {
                    { 3, "Exploring trails and nature on weekends", 3, "Hiking" },
                    { 4, "Taking photos of landscapes and people", 4, "Photography" },
                    { 5, "Enjoy reading fiction and non-fiction books", 5, "Reading" }
                });

            migrationBuilder.UpdateData(
                table: "MicrosoftServices",
                keyColumn: "ServiceId",
                keyValue: 1,
                column: "ServiceDescription",
                value: "Azure is a cloud computing platform and service created by Microsoft. It provides a wide range of cloud services, including those for computing, analytics, storage, and networking.");

            migrationBuilder.UpdateData(
                table: "MicrosoftServices",
                keyColumn: "ServiceId",
                keyValue: 2,
                column: "ServiceDescription",
                value: "Office 365 is a subscription-based service that provides access to productivity applications such as Word, Excel, PowerPoint, Outlook, and OneDrive.");

            migrationBuilder.InsertData(
                table: "MicrosoftServices",
                columns: new[] { "ServiceId", "ServiceCategory", "ServiceDescription", "ServiceName", "SubscriptionCost" },
                values: new object[,]
                {
                    { 3, "Collaboration", "A collaboration platform that combines chat, meetings, notes, and attachments.", "Microsoft Teams", 5.0 },
                    { 4, "Storage", "Cloud storage service that allows users to store files and access them from any device.", "OneDrive", 1.99 },
                    { 5, "Analytics", "Business analytics service that provides interactive visualizations and business intelligence capabilities.", "Power BI", 9.9900000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChipotleMenus",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChipotleMenus",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChipotleMenus",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MicrosoftServices",
                keyColumn: "ServiceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MicrosoftServices",
                keyColumn: "ServiceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MicrosoftServices",
                keyColumn: "ServiceId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "MicrosoftServices",
                keyColumn: "ServiceId",
                keyValue: 1,
                column: "ServiceDescription",
                value: "Azure is a cloud computing platform and service created by Microsoft. It provides a wide range of cloud services, including those for computing, analytics, storage, and networking. Users can choose and configure these services to meet their specific needs.");

            migrationBuilder.UpdateData(
                table: "MicrosoftServices",
                keyColumn: "ServiceId",
                keyValue: 2,
                column: "ServiceDescription",
                value: "Office 365 is a subscription-based service offered by Microsoft that provides access to a suite of productivity applications and services. It includes popular applications such as Word, Excel, PowerPoint, Outlook, and OneDrive, among others. Office 365 allows users to create, edit, and collaborate on documents in real-time from any device with an internet connection.");
        }
    }
}
