using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedImageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Images_ImageId",
                table: "Devices");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Devices_ImageId",
                table: "Devices");

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
                name: "ImageId",
                table: "Devices");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67802011-a03e-4aa0-91a0-d030b39e12b8", "AQAAAAIAAYagAAAAEAXm+D9dR7XbqgYgZcvCB5SAhfBSSKMq/isY/yIwDXHa8dGwsbX1OnoGB8zh2AeYDQ==", "0761a914-88b4-4558-9531-30042f522afa" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f1e2a54-97d9-416e-afcd-efa94672b90a", 0, 650m, "4c40c4bc-4dc8-45ea-ad80-ed16d61bbf34", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEANyNgKzQaLftisiSsEaXY2srCWbcayI4z6iQXrzhFqPPEXtCdAuoqWSw2x+nhdcnA==", null, false, "fd2191e9-d0fb-4f89-b022-1ab2cfa40537", false, "rick@example.com" },
                    { "8d444423-6e84-4fab-94d2-873c8588257a", 0, 450m, "9b504dd0-177c-4a9e-ba9b-2efa591d25fd", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDP1GsAAQ26S4smD1YdjG2lthw/fKfpAFJ7K9j29fg4s0Bld/orBL8A0z6dx3qPuuw==", null, false, "acd87504-08a4-4eee-b325-f025a39bbc92", false, "bruce@example.com" },
                    { "a8570272-db34-4b83-8361-44b146d9b0a2", 0, 500m, "92c6f611-dddd-4a64-8ac6-836a7261da56", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBYLsEK05TcvBsKYKbBcVAUkWkpyZ4+SXLC7fPxsnKW+i0eL4bmSDoYG6ImMhrpOZQ==", null, false, "a02eea27-a313-4925-81e9-f85fc5f8eb85", false, "gijs@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f1e2a54-97d9-416e-afcd-efa94672b90a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d444423-6e84-4fab-94d2-873c8588257a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8570272-db34-4b83-8361-44b146d9b0a2");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Devices");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ImageId",
                table: "Devices",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Images_ImageId",
                table: "Devices",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }
    }
}
