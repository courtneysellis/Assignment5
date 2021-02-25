using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment5.Migrations
{
    public partial class AddNumPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumPages",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumPages",
                table: "Books");
        }
    }
}
