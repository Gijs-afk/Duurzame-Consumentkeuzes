using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class DevicesMetSlechtLabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca52d617-4bcd-4429-897a-89f43786d0d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ee95f0-a8bf-4d2b-a371-1cb9dbf84a0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db0f2ef1-0a19-4dc8-955e-c7069a7855ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4362d8af-34dc-4ceb-935e-c1a43a4dbf21", "AQAAAAIAAYagAAAAEMoS3lJT8W+9agsUYZ/WIB/U4uehw46WYn2qV122XCRVdEJJXLinAgD66q8eCvC31w==", "cbb41e36-9fc2-414a-b69b-8888d190f964" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "33883584-cad2-4374-8201-c33433cf4d62", 0, 500m, "d4fb84f4-335c-408a-8e6c-e374a4391f46", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAGWaZouU5juXzIZhpe9A7NcZ47bMcwwNp9Ot30sSh8riir8P2HJdRTyHT6/+VA1cw==", null, false, "aa4eb2f2-b486-4916-9680-8867476fffd0", false, "gijs@example.com" },
                    { "7fe63ab2-9fd0-4fea-91f2-29ca0253014b", 0, 450m, "075c91ea-ab70-4053-b7a7-e3f40dbef202", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAWv7Krz44EcaoTS2qGjQ0R3/idxhbKsjYQHU3tqm+TqEEqYo1imEN9dUu0bcomnKQ==", null, false, "390095ad-6aec-4348-8d83-b46e9dd4639b", false, "bruce@example.com" },
                    { "c16c8284-ab95-4bde-a6ef-9f794adb1c06", 0, 650m, "77c5576f-8ec3-413a-ae45-bb95fa72a806", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDDKdc0kHHAUDcAY/CMexJiqpK9/QN5N/fRloORy0r3S+zSGLC/68W1N9AI7kYKQ8A==", null, false, "6d014bcb-7f29-4bca-a852-6108d73d2409", false, "rick@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Brand", "BuildDate", "EnergyLabelId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 23, "Bosch", null, 5, "/images/devices/wasmachines/bosch-wna14420nl.png", "Bosch WNA14420NL", 898m, "Wasmachine" },
                    { 24, "AEG", null, 6, "/images/devices/wasmachines/aeg-l6tb62k.png", "AEG L6TB62K", 599m, "Wasmachine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33883584-cad2-4374-8201-c33433cf4d62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fe63ab2-9fd0-4fea-91f2-29ca0253014b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c16c8284-ab95-4bde-a6ef-9f794adb1c06");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f75952f9-297e-40e3-97c1-27a937da38ed", "AQAAAAIAAYagAAAAED2RQggumK9fWHiGjYYl/uVKtmeuBKmHP+e20W5LIr959r3t/5YGxysoPrFjegFflA==", "c4acf121-613c-4949-9ecf-94c300b97ab5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ca52d617-4bcd-4429-897a-89f43786d0d3", 0, 650m, "de432db3-74de-450e-b933-62d3e5d96638", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAQjPxRi3sTk2M62ssrgnlHCdxPdV5ovyOrjZ3C8YX/agd9HSYbSgSyDy4kdeoEy/w==", null, false, "a13164b9-88ac-42ae-9c2f-c7db464b2abf", false, "rick@example.com" },
                    { "d1ee95f0-a8bf-4d2b-a371-1cb9dbf84a0b", 0, 500m, "4bdc4943-1475-4ac7-be7f-cb02581ded67", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAENpEJ0QvCFzBVogYFFwCzqFJhlzECKjDTlvlfdWO1gUv8DYa0r8yrRlrVqAKOPUpcQ==", null, false, "8ff78077-6ef1-4dde-8e65-edc6df02e58d", false, "gijs@example.com" },
                    { "db0f2ef1-0a19-4dc8-955e-c7069a7855ed", 0, 450m, "b43e8e95-26d3-4a95-8f2f-2d536b68a562", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKmRXBgCJjDk1/BiveF40X3LsCXrtc79pmF/RubgZhFREBkaFietwAhg6lldL7ySng==", null, false, "b5e34192-4066-4e47-8409-567637d8b545", false, "bruce@example.com" }
                });
        }
    }
}
