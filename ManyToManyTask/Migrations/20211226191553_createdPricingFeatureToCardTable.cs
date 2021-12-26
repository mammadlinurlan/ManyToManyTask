using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToManyTask.Migrations
{
    public partial class createdPricingFeatureToCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PricingFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First = table.Column<string>(nullable: true),
                    Second = table.Column<string>(nullable: true),
                    Third = table.Column<string>(nullable: true),
                    Fourth = table.Column<string>(nullable: true),
                    Fifth = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PricingCardFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingCardId = table.Column<int>(nullable: false),
                    PricingFeatureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingCardFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PricingCardFeatures_PricingCards_PricingCardId",
                        column: x => x.PricingCardId,
                        principalTable: "PricingCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PricingCardFeatures_PricingFeatures_PricingFeatureId",
                        column: x => x.PricingFeatureId,
                        principalTable: "PricingFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PricingCardFeatures_PricingCardId",
                table: "PricingCardFeatures",
                column: "PricingCardId");

            migrationBuilder.CreateIndex(
                name: "IX_PricingCardFeatures_PricingFeatureId",
                table: "PricingCardFeatures",
                column: "PricingFeatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingCardFeatures");

            migrationBuilder.DropTable(
                name: "PricingCards");

            migrationBuilder.DropTable(
                name: "PricingFeatures");
        }
    }
}
