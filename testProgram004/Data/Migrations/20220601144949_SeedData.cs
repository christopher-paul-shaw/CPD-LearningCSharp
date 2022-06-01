using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testProgram004.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Middlename", "Title" },
                values: new object[] { 1, "tttestington@emailprovider.com", "Test", "Testington", "T", "Mr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
