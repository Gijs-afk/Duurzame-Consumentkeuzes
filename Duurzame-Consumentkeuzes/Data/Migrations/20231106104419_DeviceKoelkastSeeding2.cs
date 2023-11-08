using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeviceKoelkastSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e3dde5b-014e-4254-9f2c-fbfe80c34d56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7114e21d-ff20-41e6-87a7-e5f652d350a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "889d2c53-d89e-4d1a-a089-a0da517c8ffd");

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

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 1249m);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 839m);

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Brand", "BuildDate", "EnergyLabelId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 16, "Etna", null, 1, "/images/devices/koelkasten/etna-kks4088.png", "Etna KKS4088", 348m, "Koelkast" },
                    { 17, "Siemens", null, 1, "/images/devices/koelkasten/siemens-ku15raff0.png", "Siemens KU15RAFF0", 576m, "Koelkast" },
                    { 18, "Siemens", null, 1, "/images/devices/koelkasten/siemens-ki51fade0.png", "Siemens KI51FADE0", 893.36m, "Koelkast" },
                    { 19, "Etna", null, 1, "/images/devices/koelkasten/etna-kkd4122.png", "Etna KKD4122 ", 499m, "Koelkast" },
                    { 20, "Bosch", null, 1, "/images/devices/koelkasten/bosch-ksv33vlep.png", "Bosch KSV33VLEP", 719m, "Koelkast" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2faf7b0b-95fb-4180-a03b-dfd70198fbd4", "AQAAAAIAAYagAAAAENAxPf09thkWrpZI1zod8ZL4qBTKYZHgJFLLtMH/uOs+KSXbislhooQ+BvhxofN/9A==", "a2e201fc-78c9-43ce-b0a0-8f05ce44ce87" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3e3dde5b-014e-4254-9f2c-fbfe80c34d56", 0, 650m, "b60c5188-fbb9-4266-bb66-190747017c82", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEItLyU5pcIXLndw8YH+AxA2cG2qoSM5evxGlQ5ZOaLtGRABdWCPA4GHXThkAn+wLFA==", null, false, "165745b8-89f4-49e2-a95a-90222a24361b", false, "rick@example.com" },
                    { "7114e21d-ff20-41e6-87a7-e5f652d350a9", 0, 500m, "cd6b0b6d-da46-470a-a121-1dd1c084d07e", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAENUWPP8IxeO1AuQVoIJk3D62/sN0gtWhgRcgWuNsa1X3YJymXs3no6LCTx5ep1x+6g==", null, false, "962ebdbc-4038-4c31-b794-a380764044e4", false, "gijs@example.com" },
                    { "889d2c53-d89e-4d1a-a089-a0da517c8ffd", 0, 450m, "db9be015-d3f9-4904-999e-fdb0eb452439", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECAkn26KGbI7xjoqHv+LEqms3tgPddKcfcLm6PaakOhF860cgXa7si+3vgsPPgrpRA==", null, false, "d2d7d655-8072-433b-a963-d9b2850c65f8", false, "bruce@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 41.60m);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 47.60m);
        }
    }
}
