using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToManyTask.Migrations
{
    public partial class createdCardToCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatureCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeaturedCategoryCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureCardId = table.Column<int>(nullable: false),
                    FeatureCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturedCategoryCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeaturedCategoryCards_FeatureCards_FeatureCardId",
                        column: x => x.FeatureCardId,
                        principalTable: "FeatureCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeaturedCategoryCards_FeatureCategories_FeatureCategoryId",
                        column: x => x.FeatureCategoryId,
                        principalTable: "FeatureCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedCategoryCards_FeatureCardId",
                table: "FeaturedCategoryCards",
                column: "FeatureCardId");

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedCategoryCards_FeatureCategoryId",
                table: "FeaturedCategoryCards",
                column: "FeatureCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeaturedCategoryCards");

            migrationBuilder.DropTable(
                name: "FeatureCards");

            migrationBuilder.DropTable(
                name: "FeatureCategories");
        }
    }
}
