using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class rolesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "808ec102-b584-445c-9577-71a493aaf5a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a1e01f-29d1-4d7e-913b-495c78ac9a4e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af93fbd7-ac83-4dec-8052-a558ed74020f", "b2b3c742-b906-4d38-9bb2-c3502725c71f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b46d275-62ab-4f2e-865d-757b33486b97", "f461197e-5c81-4111-910c-bb28e6276cec", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b46d275-62ab-4f2e-865d-757b33486b97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af93fbd7-ac83-4dec-8052-a558ed74020f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "808ec102-b584-445c-9577-71a493aaf5a9", "10888b75-557a-46ef-9882-2bf84f70142e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0a1e01f-29d1-4d7e-913b-495c78ac9a4e", "636fd8cb-0dd5-4dfe-9508-d0e1dfc8fe2c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
