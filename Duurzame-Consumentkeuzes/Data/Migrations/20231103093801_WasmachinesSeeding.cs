using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class WasmachinesSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ae37372-09e5-4438-b80c-8fecee945418");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ebd9892-beb4-497d-9d38-d3624f9ed659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35598964-1502-4a0f-a5d0-4932be9512b8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10fc573e-3ecb-4fca-a0cd-bdfe2e3cf67c", "AQAAAAIAAYagAAAAEIDd+sp5DNPXmAytvQIM2xiyy0ya4vVJcTQsXxLAZC5BMfuKl6f/fPArQDVdvYHnSA==", "f01ce7f7-38c2-4bca-8c62-5a9c79d592d3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12755b00-505b-47c3-9332-8fe19a0d314a", 0, 500m, "fa217d44-50ea-4411-84f3-09447bd83b18", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ7V47Pu2983t2qjcUFVIh1jKXl1rUGcKzRmYsH9QeGUU7loYx+G39ajO4r+TB9mKg==", null, false, "02aa0e7d-740b-4f12-894e-4d5024d6c431", false, "gijs@example.com" },
                    { "43bd69a6-0cfa-4e31-98b7-6e302af4a071", 0, 450m, "30708a3b-150c-4400-b91e-35599a45ed40", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP4k3sns5xBZq70OUdKBKAb+/aCreHDJDNzswy52vb5NamqiqwUyLl/9scmZ+POzrQ==", null, false, "b8c5c99c-0fc0-4ddc-a0fd-f26f70bfaa47", false, "bruce@example.com" },
                    { "e0a745ac-2deb-4a12-a136-0d72c5a42b0d", 0, 650m, "f3664782-16c7-4f11-ac0a-72aea5c8a789", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAQcN5pObxqw9YT7HJ8+W5LoDphFKMzFdVqBjqcICvKX9/pMhp00Q3f1EoabWyPaMw==", null, false, "199e6ba1-e1ce-4487-a1bc-f6372645e447", false, "rick@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Brand", "BuildDate", "EnergyLabelId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 4, "AEG", null, 1, "/images/devices/aeg-lr6berlin.png", "AEG LR6BERLIN", 649m, "Wasmachine" },
                    { 5, "Siemens", null, 1, "/images/devices/siemens-iq700-wg56b2a5nl.png", "Siemens IQ700 WG56B2A5NL", 1099m, "Wasmachine" },
                    { 6, "Bosch", null, 1, "/images/devices/bosch-serie-6-wau28p95nl.png", "Bosch Serie | 6 WAU28P95NL", 875m, "Wasmachine" },
                    { 7, "Siemens", null, 1, "/images/devices/siemens-iq300-wm14n297nl.png", "Siemens IQ300 WM14N297NL", 779m, "Wasmachine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12755b00-505b-47c3-9332-8fe19a0d314a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bd69a6-0cfa-4e31-98b7-6e302af4a071");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0a745ac-2deb-4a12-a136-0d72c5a42b0d");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9913544-afa5-426f-9867-11a44df2c7e8", "AQAAAAIAAYagAAAAEEkeU884J+KLOQ9SdgNCZaObw/qyulCZ6w/av0lPnkLJnUvjE0yVpDiKSomgCckPVA==", "d85c52f3-172d-4480-856c-dc4798d3f3ad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2ae37372-09e5-4438-b80c-8fecee945418", 0, 450m, "29f22ba7-aebf-44eb-85be-1aaeb6164d08", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDtVTafb1RLhp9NnoFX53L3sTL9opY7DBPdpimJtnIoVWNPluC9tRmKvNgiuSDyhXg==", null, false, "61176701-37c1-41eb-b3b1-518c6dfde1fd", false, "bruce@example.com" },
                    { "2ebd9892-beb4-497d-9d38-d3624f9ed659", 0, 650m, "bdc3b5d4-8a04-4b59-8479-50cddedc38a5", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHqoZ8qOZpsozTyh0S2qlM19Lh73WnyMVVH+W7F9INeUN0/YfjAwhqjRM/Ol30CBPg==", null, false, "a4164e6f-dd79-4fd3-9f2c-e41e0d8d3937", false, "rick@example.com" },
                    { "35598964-1502-4a0f-a5d0-4932be9512b8", 0, 500m, "98a1a441-4c80-4179-bf75-fe9e0d440189", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMEpYbrrQySgjJNqR3XvMVRteQtVEHXMndPVUXPcz8pt5a0uobgbk9O2JUr5URfRRw==", null, false, "1cb2812c-58b4-4c19-a7c2-99f194ab79d4", false, "gijs@example.com" }
                });
        }
    }
}
