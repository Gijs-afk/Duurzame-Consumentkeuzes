using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class EnergyLabelImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "EnergyLabels",
                type: "nvarchar(max)",
                nullable: true);

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
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/energylabels/energylabela.png");

            migrationBuilder.UpdateData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/energylabels/energylabelb.png");

            migrationBuilder.UpdateData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/energylabels/energylabelc.png");

            migrationBuilder.UpdateData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/images/energylabels/energylabeld.png");

            migrationBuilder.UpdateData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "/images/energylabels/energylabele.png");

            migrationBuilder.UpdateData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "/images/energylabels/energylabelf.png");

            migrationBuilder.InsertData(
                table: "EnergyLabels",
                columns: new[] { "Id", "EfficiencyClass", "ImagePath" },
                values: new object[] { 7, "G", "/images/energylabels/energylabelg.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "EnergyLabels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "EnergyLabels");

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
    }
}
