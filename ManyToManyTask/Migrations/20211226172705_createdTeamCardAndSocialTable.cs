using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToManyTask.Migrations
{
    public partial class createdTeamCardAndSocialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    TeamCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Socials_TeamCards_TeamCardId",
                        column: x => x.TeamCardId,
                        principalTable: "TeamCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Socials_TeamCardId",
                table: "Socials",
                column: "TeamCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "TeamCards");
        }
    }
}
