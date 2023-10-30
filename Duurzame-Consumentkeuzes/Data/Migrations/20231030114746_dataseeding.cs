using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", null, "Administrators", "ADMINISTRATORS" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "372725a0-0897-4dd1-a77a-0f9cce9ca7ad", 0, null, "dbc737c9-dc30-4553-8eb1-73d7c8e89259", "admin@example.com", false, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOfMoizIWQ6zJf/P1uWKGJ6n0QiuTegwsbhHFU9g5zgNJTD7HX9B+ImLRxiEWYJioQ==", null, false, "55505fbd-b058-4081-95d1-4fbbc4046c3e", false, "admin@example.com" },
                    { "463b5954-d37f-4bd4-9584-3fe275995d3e", 0, 500m, "4bcd72d9-26e7-4d53-9c1e-e9a94606cad2", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJYQfcB0xFYq2UkJh1s/nFzw4WgHFeXJ9DHDZX/jr+Rahjyf3lTEFQwMlg+ejzupVg==", null, false, "6b1ca481-3acb-4083-8fd0-15b87791268b", false, "gijs@example.com" },
                    { "dba89a8e-e83e-49c2-9e04-6b96c5acf74d", 0, 650m, "06d9890a-1b54-45c1-82c9-f3ab9e33fbb5", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKODM5AKrycvf0OYpvaZP0Veg+VXR5n2USYIjKi7yrh79qlTW4oEydcB4Lp1Om8Q0A==", null, false, "72c46193-0ddb-45ab-b214-4b4a33c4524a", false, "rick@example.com" },
                    { "eb4a3d9e-7ad6-4a29-8e71-fd31fb47d3ad", 0, 450m, "cfed7e78-42c0-4e85-95a2-d7fbb98f11d8", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP2yzQSWFgfo0V0egwU5c17D1FvAeD0AhNBXznRhiQq4CjVjFPAZGzGsq2trJPOOiA==", null, false, "56607857-134f-4697-b3dd-01569f38027b", false, "bruce@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", "372725a0-0897-4dd1-a77a-0f9cce9ca7ad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0f4adb4-8c3d-45ff-a814-62c3c873fba5", "372725a0-0897-4dd1-a77a-0f9cce9ca7ad" });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0f4adb4-8c3d-45ff-a814-62c3c873fba5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad");
        }
    }
}
