using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class EnergyLabelAttributeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a4bf5a2-0f09-4783-b75b-b2dbe2358bdd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70325f7b-f1d7-4fbe-bb40-745207766b65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "715fb72b-9983-4f4b-bf95-a04c15d403f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c1cb98d-dc17-4da8-a195-c481fddf9c43", "AQAAAAIAAYagAAAAEDTpXk/jc6CGE33y1Ibipq6Gv3IGbEOWfml7Gvz/2HgNkMododvYPGrqIKPHojSoaA==", "c18f5c20-42e5-498f-b2a9-c9fdc83bea7c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0331fe41-7a4f-42f9-9f1b-e838f3179540", 0, 500m, "7ad52a1e-3429-475f-9a0c-db1622f8904a", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMT7EQKtMSJtqJfPEkY+bwf3eC/dgJqNWLMjsvgU9diyRyAB23w+vpbqsqtgvYF2yA==", null, false, "ee3df0a8-90c1-46e6-9015-b9465a9668e9", false, "gijs@example.com" },
                    { "417cc57e-f133-4541-adc3-3314640f5c20", 0, 450m, "a8be6bcd-078d-4b23-b23c-398890eeb589", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEODKvbNvOmRFykaBZbA446Q0PHZzyVXCL4/rTp+g7n9izEIBC8ukHoFgxjafSgD2Zw==", null, false, "0e26b01d-c2b0-4aff-8296-368413ca0d91", false, "bruce@example.com" },
                    { "f380df32-fbd1-421b-b301-19124f9a479d", 0, 650m, "dc2bd8e2-698d-4083-a4e6-fd7914ea2477", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAiMG6GUXkeauOvm+MG3t7/9vzhgJZIhiMPD42wM+jeit9X7mFIX3oq2tdM8yVqD2g==", null, false, "e804bf2e-189d-4c89-aff9-936118baa358", false, "rick@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0331fe41-7a4f-42f9-9f1b-e838f3179540");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "417cc57e-f133-4541-adc3-3314640f5c20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f380df32-fbd1-421b-b301-19124f9a479d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06c8f14b-4e07-43cf-b227-0fb376da5562", "AQAAAAIAAYagAAAAEJYACR3ueILKurVQVnpXwsd/XOK3FWJVFlC2i5lFmMuaLDkVfS1oNc1EWBSVd7qU+A==", "52a1ff83-624e-40cc-aaa3-dba7d910095d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a4bf5a2-0f09-4783-b75b-b2dbe2358bdd", 0, 450m, "85aaf7a5-eba7-46f3-b506-4fa70cbc0ea3", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECzX3ix1M1NjOUCPnXNdLkX9sIuHXEgzoA9fL32l2XFcneHmV9f8Jmg3JY+s/rj39w==", null, false, "0e0d2395-fa12-4f24-b069-927d73d3705d", false, "bruce@example.com" },
                    { "70325f7b-f1d7-4fbe-bb40-745207766b65", 0, 500m, "8864a1d0-6907-4149-91a6-8652bb630f06", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ46PTlfF5qnpCMio7pbsplHYM5QTDgqJVfHeXDjifuPZVA7l89Yg5Iqvbr1phwI1w==", null, false, "63e0b462-82ca-44e4-8750-b9cd63b622ed", false, "gijs@example.com" },
                    { "715fb72b-9983-4f4b-bf95-a04c15d403f8", 0, 650m, "b64aaeed-5b0e-41f4-8709-a6370679dd54", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE0lt85PwZ1/Qrs2sRvoaWqj8ykF4aOapdCwB2n7rLHTqvaTbzJa3TNqIAe3llKK1w==", null, false, "7e9dfd03-44cf-4cdb-8e50-ba7968021038", false, "rick@example.com" }
                });
        }
    }
}
