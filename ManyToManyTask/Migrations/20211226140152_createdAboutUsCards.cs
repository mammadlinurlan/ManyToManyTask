using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToManyTask.Migrations
{
    public partial class createdAboutUsCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUsCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(nullable: true),
                    StartCount = table.Column<int>(nullable: false),
                    EndCount = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUsCards");
        }
    }
}
