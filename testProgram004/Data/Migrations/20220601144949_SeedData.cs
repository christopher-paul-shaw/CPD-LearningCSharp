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
                values: new object[,]
                {
                    { 1, "pttestington@emailprovider.com", "Pete", "Testington", "T", "Mr" }, 
                    { 2, "sttestington@emailprovider.com", "Sarah", "Testington", "T", "Mrs" }, 
                    { 3, "dttestington@emailprovider.com", "Dave", "Testington", "T", "Dr" }, 
                    { 4, "pttestington@emailprovider.com", "Pastor", "Testington", "T", "Rev" }, 
                    { 5, "bttestington@emailprovider.com", "Becky", "Testington", "T", "Ms" }, 
                }
            );
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
