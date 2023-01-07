using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class tokens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6d699a1a-3cd6-4cac-9cbb-264086fcfcdd", "b41ad770-9217-4c45-8318-7c9875a19937", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5106213-d6ae-4c5d-abb0-570545552f66", "066506af-421c-44cc-a253-f2be6eacfa2a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d699a1a-3cd6-4cac-9cbb-264086fcfcdd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5106213-d6ae-4c5d-abb0-570545552f66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af93fbd7-ac83-4dec-8052-a558ed74020f", "b2b3c742-b906-4d38-9bb2-c3502725c71f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b46d275-62ab-4f2e-865d-757b33486b97", "f461197e-5c81-4111-910c-bb28e6276cec", "Administrator", "ADMINISTRATOR" });
        }
    }
}
