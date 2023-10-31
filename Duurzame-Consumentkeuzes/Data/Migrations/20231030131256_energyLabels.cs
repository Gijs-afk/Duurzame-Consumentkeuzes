using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class energyLabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "463b5954-d37f-4bd4-9584-3fe275995d3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba89a8e-e83e-49c2-9e04-6b96c5acf74d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb4a3d9e-7ad6-4a29-8e71-fd31fb47d3ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14f1bec5-9c27-4c61-ae89-f74a08be9d8c", "AQAAAAIAAYagAAAAEMa6MmusDrMVi3a6pxIj5fA6fShAuegqKg+RpXnYVaT7akAOssIqdroDVsvgJlPNew==", "12b21e50-fb41-41a2-b08b-e137be1ddb65" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "790c56e0-19a2-408c-a9a0-6c0c7301dd8d", 0, 500m, "e6795bf4-61a6-4fbb-be1c-f5a161edc6ca", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAELcUiFekNkbzrqBicL4LGTm9smUUBAsvjKyxrlxPJKtKnx0eLoJBPHv4ga1KSv/nXw==", null, false, "a46738fb-e1a5-401f-9a21-222a44545d36", false, "gijs@example.com" },
                    { "87b04826-8f7a-41d3-a7a0-535e9e70fee3", 0, 650m, "a89bbbb5-b150-4b1f-92b5-d03757706f18", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB6BOgWfLYdfcc6ObK3koJZ9otWK2ACHzKDrXNd7lWRrFo8iw3iiLIr84C8GI9ImaQ==", null, false, "f5b2acc6-28db-4a16-bf99-98a6275f94cd", false, "rick@example.com" },
                    { "f0583d6d-c029-4bab-bc27-cfde2acf8abe", 0, 450m, "642a1de3-d2ad-4819-bc15-7091f80114d4", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJq7uPDqrEbPHjyD7wO+QYnpZQ1vEIdkdgS+3/GTRIEXD/upitmMgo302qCsVbmksg==", null, false, "abadf3d7-b000-4c78-9856-94047757ec1b", false, "bruce@example.com" }
                });

            migrationBuilder.InsertData(
                table: "EnergyLabels",
                columns: new[] { "Id", "EfficiencyClass" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" },
                    { 5, "E" },
                    { 6, "F" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "790c56e0-19a2-408c-a9a0-6c0c7301dd8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87b04826-8f7a-41d3-a7a0-535e9e70fee3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0583d6d-c029-4bab-bc27-cfde2acf8abe");

            migrationBuilder.DeleteData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbc737c9-dc30-4553-8eb1-73d7c8e89259", "AQAAAAIAAYagAAAAEOfMoizIWQ6zJf/P1uWKGJ6n0QiuTegwsbhHFU9g5zgNJTD7HX9B+ImLRxiEWYJioQ==", "55505fbd-b058-4081-95d1-4fbbc4046c3e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "463b5954-d37f-4bd4-9584-3fe275995d3e", 0, 500m, "4bcd72d9-26e7-4d53-9c1e-e9a94606cad2", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJYQfcB0xFYq2UkJh1s/nFzw4WgHFeXJ9DHDZX/jr+Rahjyf3lTEFQwMlg+ejzupVg==", null, false, "6b1ca481-3acb-4083-8fd0-15b87791268b", false, "gijs@example.com" },
                    { "dba89a8e-e83e-49c2-9e04-6b96c5acf74d", 0, 650m, "06d9890a-1b54-45c1-82c9-f3ab9e33fbb5", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKODM5AKrycvf0OYpvaZP0Veg+VXR5n2USYIjKi7yrh79qlTW4oEydcB4Lp1Om8Q0A==", null, false, "72c46193-0ddb-45ab-b214-4b4a33c4524a", false, "rick@example.com" },
                    { "eb4a3d9e-7ad6-4a29-8e71-fd31fb47d3ad", 0, 450m, "cfed7e78-42c0-4e85-95a2-d7fbb98f11d8", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP2yzQSWFgfo0V0egwU5c17D1FvAeD0AhNBXznRhiQq4CjVjFPAZGzGsq2trJPOOiA==", null, false, "56607857-134f-4697-b3dd-01569f38027b", false, "bruce@example.com" }
                });
        }
    }
}
