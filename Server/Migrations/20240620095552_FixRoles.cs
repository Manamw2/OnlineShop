using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class FixRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a14ac99-ad74-4c7f-bf06-50b0838a5453");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fed456-9b4c-41aa-9dfa-393bb1821861");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e07b20b2-9428-405b-b8cb-c3c4c1a47ad2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "126979f1-58ae-4a6d-923e-fefdacbbbf85", null, "Role", "admin", "ADMIN" },
                    { "7aff5014-5606-4268-83ad-a6036242b842", null, "Role", "superadmin", "SUPERADMIN" },
                    { "9385f9f0-923a-439c-896e-0fa32a8c15d8", null, "Role", "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126979f1-58ae-4a6d-923e-fefdacbbbf85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aff5014-5606-4268-83ad-a6036242b842");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9385f9f0-923a-439c-896e-0fa32a8c15d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a14ac99-ad74-4c7f-bf06-50b0838a5453", null, "IdentityRole", "superadmin", "SUPERADMIN" },
                    { "91fed456-9b4c-41aa-9dfa-393bb1821861", null, "IdentityRole", "admin", "ADMIN" },
                    { "e07b20b2-9428-405b-b8cb-c3c4c1a47ad2", null, "IdentityRole", "user", "USER" }
                });
        }
    }
}
