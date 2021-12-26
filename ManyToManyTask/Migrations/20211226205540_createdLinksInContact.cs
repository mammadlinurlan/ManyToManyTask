using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToManyTask.Migrations
{
    public partial class createdLinksInContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Contacts");
        }
    }
}
