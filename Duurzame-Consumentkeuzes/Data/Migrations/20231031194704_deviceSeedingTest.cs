using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Duurzame_Consumentkeuzes.Data.Migrations
{
    /// <inheritdoc />
    public partial class deviceSeedingTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06c8f14b-4e07-43cf-b227-0fb376da5562", "AQAAAAIAAYagAAAAEJYACR3ueILKurVQVnpXwsd/XOK3FWJVFlC2i5lFmMuaLDkVfS1oNc1EWBSVd7qU+A==", "52a1ff83-624e-40cc-aaa3-dba7d910095d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Budget", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a4bf5a2-0f09-4783-b75b-b2dbe2358bdd", 0, 450m, "85aaf7a5-eba7-46f3-b506-4fa70cbc0ea3", "bruce@example.com", false, false, null, "BRUCE@EXAMPLE.COM", "BRUCE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECzX3ix1M1NjOUCPnXNdLkX9sIuHXEgzoA9fL32l2XFcneHmV9f8Jmg3JY+s/rj39w==", null, false, "0e0d2395-fa12-4f24-b069-927d73d3705d", false, "bruce@example.com" },
                    { "70325f7b-f1d7-4fbe-bb40-745207766b65", 0, 500m, "8864a1d0-6907-4149-91a6-8652bb630f06", "gijs@example.com", false, false, null, "GIJS@EXAMPLE.COM", "GIJS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ46PTlfF5qnpCMio7pbsplHYM5QTDgqJVfHeXDjifuPZVA7l89Yg5Iqvbr1phwI1w==", null, false, "63e0b462-82ca-44e4-8750-b9cd63b622ed", false, "gijs@example.com" },
                    { "715fb72b-9983-4f4b-bf95-a04c15d403f8", 0, 650m, "b64aaeed-5b0e-41f4-8709-a6370679dd54", "rick@example.com", false, false, null, "RICK@EXAMPLE.COM", "RICK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE0lt85PwZ1/Qrs2sRvoaWqj8ykF4aOapdCwB2n7rLHTqvaTbzJa3TNqIAe3llKK1w==", null, false, "7e9dfd03-44cf-4cdb-8e50-ba7968021038", false, "rick@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Brand", "BuildDate", "EnergyLabelId", "ImagePath", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "Haier", null, 1, "'/images/haier-hw90-b14959u1.png'", "Haier HW90 B14959U1", 599m, "Wasmachine" },
                    { 2, "Samsung", null, 1, "'/images/samsung-ww90t534aaw.png'", "Samsung WW90T534AAW", 649m, "Wasmachine" },
                    { 3, "Bosch", null, 1, "'/images/bosch-serie-4-wgg04409nl.png'", "Bosch Serie | 4 WGG04409NL", 699m, "Wasmachine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a4bf5a2-0f09-4783-b75b-b2dbe2358bdd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70325f7b-f1d7-4fbe-bb40-745207766b65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "715fb72b-9983-4f4b-bf95-a04c15d403f8");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
