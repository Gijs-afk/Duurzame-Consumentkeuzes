using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeviceKoelkastSeeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a3c71a-4799-4807-9d81-83d686e53426");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "604bb1d1-5a86-476b-b6df-f81c3322753a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4c3d565-22bd-4a89-ae32-fd7356c4bb0b");

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

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Brand", "BuildDate", "EnergyLabelId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 11, "Bosch", null, 1, "/images/devices/koelkasten/bosch-serie-6-kgn39aiat.png", "Bosch Serie | 6 KGN39AIAT", 41.60m, "Koelkast" },
                    { 12, "Siemens", null, 2, "/images/devices/koelkasten/siemens-kg39e8xba.png", "Siemens KG39E8XBA", 47.60m, "Koelkast" },
                    { 13, "LG", null, 2, "/images/devices/koelkasten/lg-gbp62pznbc.png", "LG GBP62PZNBC", 1009m, "Koelkast" },
                    { 14, "LG", null, 1, "/images/devices/koelkasten/lg-gbb92stbap.png", "LG GBB92STBAP", 1378m, "Koelkast" },
                    { 15, "Siemens", null, 1, "/images/devices/koelkasten/siemens-iq500-kg39naiat.png", "Siemens IQ500 KG39NAIAT", 1399m, "Koelkast" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d134689-8f2b-4952-a4a5-371c4049dd98", "AQAAAAIAAYagAAAAEJ4l96OPeoBFHDL3DZCkXqxj8br683A4a7Pl6rT9fHVHqDsv66u4rr8ctQf8tgHQEg==", "55c0846a-a14b-4912-b2fd-670812c84023" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16a3c71a-4799-4807-9d81-83d686e53426", 0, 450m, "6427e2b6-8de4-4001-a72a-902435f4c852", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG0O8VhVgBdbAA6KB0TwTUlqnZkIwK5sHBtZBgvxNbeVHBu8N8bMPjjbfZGyxy+rUw==", null, false, "ba417626-951b-4662-a024-bf03fcb1a82d", false, "bruce@example.com" },
                    { "604bb1d1-5a86-476b-b6df-f81c3322753a", 0, 650m, "f366c887-aba1-46ba-8da0-6f3542ccd009", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ8K4jBLr81d9vexrEd76W6Qsmhek8cRKIrRjUEFAh9/PuqgFK862/ms9BLPZRSLQw==", null, false, "33db3ecc-8d47-41b4-9772-878bc2dc58f1", false, "rick@example.com" },
                    { "c4c3d565-22bd-4a89-ae32-fd7356c4bb0b", 0, 500m, "9e703f9e-7aff-47fe-b91c-b03d6413b1b8", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIciFfUH/VwSTJHtpCSvlTqu90xLbUQDpy2lug0BJZSBmuJewUxYK5wXamxP3ml9XQ==", null, false, "2a096476-0b30-4ae5-8ea0-88a7ff1c92c1", false, "gijs@example.com" }
                });
        }
    }
}
