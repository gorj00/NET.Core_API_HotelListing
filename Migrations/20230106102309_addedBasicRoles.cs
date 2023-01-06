using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class addedBasicRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f27aff9-c5b8-4a10-aa09-39bf8d0b7df0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a93c1199-0eca-4b14-93ca-7054719f6ea2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "808ec102-b584-445c-9577-71a493aaf5a9", "10888b75-557a-46ef-9882-2bf84f70142e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0a1e01f-29d1-4d7e-913b-495c78ac9a4e", "636fd8cb-0dd5-4dfe-9508-d0e1dfc8fe2c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9f27aff9-c5b8-4a10-aa09-39bf8d0b7df0", "c75a31ad-d429-4f46-b401-757f431dc6d9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a93c1199-0eca-4b14-93ca-7054719f6ea2", "faf44faa-29df-4594-be28-d2f92b56e1c2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
