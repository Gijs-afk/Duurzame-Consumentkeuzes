using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImagePathFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "803b7b33-ed1a-4f7c-9a61-81e512e049a0", "AQAAAAIAAYagAAAAELUgW+Dra1DAIBaU32DcZvRbFbLUzXLXqc5TGJPpyGQkmAa0SyxkSJaJw1oqtBoJVQ==", "54c42f5f-648c-4920-b87b-b9680d610a0b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7a699edf-efc1-4ce9-af58-fdefba844bee", 0, 450m, "a19cc61d-e154-4d76-9edc-5743db26a64b", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN3RgbYo5W6CPmMC6DqumdidbLYrvtSXhPXwcKLbT2hWj0My+/sbsI1vi+vfneTR0w==", null, false, "75cf51ba-d957-4fcd-ae7e-91a625eb756f", false, "bruce@example.com" },
                    { "8e8c5c62-9f05-4878-a346-b3e8585ca15c", 0, 650m, "24b7e3fe-05f4-40e8-9a36-ca19f4a7e7a9", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAED4Wcyu6Eze9nPM/8EsT7cpqByUo2xt/eE9m+hVrk0cHyt6WO/yNDlMDxr7EFtRkSw==", null, false, "a15d5302-6997-4ce5-aba2-a703feb7f9fb", false, "rick@example.com" },
                    { "ce367ccb-6d80-45f9-9794-8e62c847db22", 0, 500m, "98a21a34-c020-4ebf-900e-40552c9ec9c4", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF2YgJ7ouWcXt25yXVc7Gb8Bo7CXp93ouwDBOlcnOa+JJsjpC0tdEr1IFHtEewLMbA==", null, false, "30688064-546a-4ab4-a009-e4f22e73ef08", false, "gijs@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/haier-hw90-b14959u1.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/samsung-ww90t534aaw.png");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/bosch-serie-4-wgg04409nl.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a699edf-efc1-4ce9-af58-fdefba844bee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e8c5c62-9f05-4878-a346-b3e8585ca15c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce367ccb-6d80-45f9-9794-8e62c847db22");

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

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "'/images/haier-hw90-b14959u1.png'");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "'/images/samsung-ww90t534aaw.png'");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "'/images/bosch-serie-4-wgg04409nl.png'");
        }
    }
}
