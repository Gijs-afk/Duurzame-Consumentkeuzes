using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class WasmachineSeeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "724d24c8-22d8-4d4a-b864-7db96959ffd6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f556252-e112-4ef3-bfd5-28a3af774bce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d92d9a75-9fc1-489a-b644-1b41dd46c0b6");

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

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Brand", "BuildDate", "EnergyLabelId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 21, "AEG", null, 1, "/images/devices/wasmachines/aeg-lwr7796ud6.png", "AEG LWR7796UD6", 1249m, "Wasmachine" },
                    { 22, "Samsung", null, 1, "/images/devices/wasmachines/samsung-bespoke-autodose-5000-serie-ww11bb534aabs2.png", "Samsung Bespoke Autodose 5000 serie WW11BB534AABS2", 749m, "Wasmachine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e835a53e-1fe4-4471-9dd9-8ee6ecf7aadb", "AQAAAAIAAYagAAAAEPgia2Rt5PgNeFCSlW9Wsh40pn9XqkKGVWDI5ktG87Dbz99kg0TM1p9HLhmucAM18w==", "5afcaa8f-6fad-4845-b795-652249fe0a2f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "724d24c8-22d8-4d4a-b864-7db96959ffd6", 0, 500m, "57357040-8953-44c4-9eaf-8d9714c6a52e", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAECCryw3C7VInmouVS7Lp3C4tKceW8B4Ipn8UzFYm96CZjPG9UhBvTKpseghVzZfitA==", null, false, "ecfaf3cc-b068-42bc-b66f-7b2e1fb8f6bf", false, "gijs@example.com" },
                    { "7f556252-e112-4ef3-bfd5-28a3af774bce", 0, 650m, "85984fa8-2c60-48a1-bf65-2ac0f08d3d09", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEElC+9SLvgKtXscPH3BiwLIAU9XQIL4pNapVaQzbuiyHCHnSiR3bC13lfAsA13TkA==", null, false, "d40582e5-b617-4a50-91fd-f81d8d485671", false, "rick@example.com" },
                    { "d92d9a75-9fc1-489a-b644-1b41dd46c0b6", 0, 450m, "7c3b11e0-b8ea-486f-be77-f979d09aac0e", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDvtYMa4QeTNcf18C6X6Wm/aPhs8HKZTjCTML/gwksZC4vLd7ofSkgNtkQ9TLN3/jw==", null, false, "9abf97e7-07ae-4f23-94a8-bcef88d0025a", false, "bruce@example.com" }
                });
        }
    }
}
