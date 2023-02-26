using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo_test_api.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fic",
                table: "Fibonacci",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fic",
                table: "Fibonacci");
        }
    }
}
