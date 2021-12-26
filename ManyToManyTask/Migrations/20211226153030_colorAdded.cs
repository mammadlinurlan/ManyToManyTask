using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToManyTask.Migrations
{
    public partial class colorAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Features",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Features");
        }
    }
}
