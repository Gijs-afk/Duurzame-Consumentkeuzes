using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class WasmachinesSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/devices/wasmachines/haier-hw90-b14959u1.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/devices/wasmachines/samsung-ww90t534aaw.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/devices/wasmachines/bosch-serie-4-wgg04409nl.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/images/devices/wasmachines/aeg-lr6berlin.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "/images/devices/wasmachines/siemens-iq700-wg56b2a5nl.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "/images/devices/wasmachines/bosch-serie-6-wau28p95nl.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "/images/devices/wasmachines/siemens-iq300-wm14n297nl.png");

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Brand", "BuildDate", "EnergyLabelId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 8, "Beko", null, 3, "/images/devices/wasmachines/beko-wtv8712blw1.png", "Beko WTV8712BLW1", 399m, "Wasmachine" },
                    { 9, "Whirlpool", null, 2, "/images/devices/wasmachines/whirlpool-ffb-9458-wv-be.png", "Whirlpool FFB 9458 WV BE", 403m, "Wasmachine" },
                    { 10, "Beko", null, 3, "/images/devices/wasmachines/beko-wtv8711bc1.png", "Beko WTV8711BC1", 429m, "Wasmachine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/devices/haier-hw90-b14959u1.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/devices/samsung-ww90t534aaw.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/devices/bosch-serie-4-wgg04409nl.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/images/devices/aeg-lr6berlin.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "/images/devices/siemens-iq700-wg56b2a5nl.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "/images/devices/bosch-serie-6-wau28p95nl.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "/images/devices/siemens-iq300-wm14n297nl.png");
        }
    }
}
