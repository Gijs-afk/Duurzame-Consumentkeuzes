using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class DevicePrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "790c56e0-19a2-408c-a9a0-6c0c7301dd8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87b04826-8f7a-41d3-a7a0-535e9e70fee3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0583d6d-c029-4bab-bc27-cfde2acf8abe");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Devices",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe16f9d4-7d7b-4673-9948-c2b621fe9c63", "AQAAAAIAAYagAAAAENA3bLAn3rB/iMAklPQL0GIRnwS1jgkLMd7UXhBNDZi7eOCOtlc4vvU36ojmLDN8/w==", "f0fe3ae9-369e-410f-8874-3061e785f664" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48f1e78c-3c89-49e6-936f-71a9cf052654", 0, 650m, "c51e1e40-1c42-4b1e-b74c-b556199e07ba", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKlPSG4YlYp0llczSVwLvuO0Va5iLs5fESCzBCcTkfbxjYSZsIQV8UFgxE7fw+KPGw==", null, false, "0925aeba-d01f-4923-9527-29cd5d88949e", false, "rick@example.com" },
                    { "e3d90dfe-2344-48a5-b19c-aa39d56d1420", 0, 450m, "8396dd6a-391e-49da-8a33-cd91f7b6b75b", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKvWm1+ToSn13FM7KaNeC0SvA816gVZ3K8gobbE+wFAcj1NL2+qOeGsIoylK8wSYdw==", null, false, "1f4f9417-914a-491b-86d5-70d61dd1212c", false, "bruce@example.com" },
                    { "f7607edd-7a81-47ed-906c-835e1436176d", 0, 500m, "b4ca927d-570b-4e99-850f-ae7d89763753", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK+dFcWZrwO4L4la2xKsrSobudwwdCNOGC+Y9umTxDB5vWBDzTo4HvFGBL8ceXN04g==", null, false, "d113ff6f-aa22-440c-83ef-ca8a74c90247", false, "gijs@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48f1e78c-3c89-49e6-936f-71a9cf052654");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d90dfe-2344-48a5-b19c-aa39d56d1420");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7607edd-7a81-47ed-906c-835e1436176d");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Devices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14f1bec5-9c27-4c61-ae89-f74a08be9d8c", "AQAAAAIAAYagAAAAEMa6MmusDrMVi3a6pxIj5fA6fShAuegqKg+RpXnYVaT7akAOssIqdroDVsvgJlPNew==", "12b21e50-fb41-41a2-b08b-e137be1ddb65" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "790c56e0-19a2-408c-a9a0-6c0c7301dd8d", 0, 500m, "e6795bf4-61a6-4fbb-be1c-f5a161edc6ca", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAELcUiFekNkbzrqBicL4LGTm9smUUBAsvjKyxrlxPJKtKnx0eLoJBPHv4ga1KSv/nXw==", null, false, "a46738fb-e1a5-401f-9a21-222a44545d36", false, "gijs@example.com" },
                    { "87b04826-8f7a-41d3-a7a0-535e9e70fee3", 0, 650m, "a89bbbb5-b150-4b1f-92b5-d03757706f18", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB6BOgWfLYdfcc6ObK3koJZ9otWK2ACHzKDrXNd7lWRrFo8iw3iiLIr84C8GI9ImaQ==", null, false, "f5b2acc6-28db-4a16-bf99-98a6275f94cd", false, "rick@example.com" },
                    { "f0583d6d-c029-4bab-bc27-cfde2acf8abe", 0, 450m, "642a1de3-d2ad-4819-bc15-7091f80114d4", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJq7uPDqrEbPHjyD7wO+QYnpZQ1vEIdkdgS+3/GTRIEXD/upitmMgo302qCsVbmksg==", null, false, "abadf3d7-b000-4c78-9856-94047757ec1b", false, "bruce@example.com" }
                });
        }
    }
}
