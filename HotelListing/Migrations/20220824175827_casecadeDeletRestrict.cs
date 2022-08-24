using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class casecadeDeletRestrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ee59685-7368-4259-9215-14ea61ab7e24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da402cd0-5d23-4a66-a775-611dfb3e3a08");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1db7b953-31f3-4b1d-a1de-8bc49d93a0be", "f9502acd-711b-4527-a95c-317578d4f5ed", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ed91bf1-8b31-417c-9f2c-05d2c214fbcf", "fe6cbb26-24a8-4c4c-a40d-1b2082b1784f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1db7b953-31f3-4b1d-a1de-8bc49d93a0be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ed91bf1-8b31-417c-9f2c-05d2c214fbcf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da402cd0-5d23-4a66-a775-611dfb3e3a08", "1ad7a0a2-9222-4a59-94eb-f03f1a34fdfc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ee59685-7368-4259-9215-14ea61ab7e24", "a4d10cc0-2694-4f48-b32c-c97fc0e9cfba", "Administrator", "ADMINISTRATOR" });
        }
    }
}
