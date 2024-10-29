using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstAppWith2Table.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblTutorials",
                columns: table => new
                {
                    TutorialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TutorialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTutorials", x => x.TutorialId);
                });

            migrationBuilder.CreateTable(
                name: "tblArticles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TutorialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_tblArticles_tblTutorials_TutorialId",
                        column: x => x.TutorialId,
                        principalTable: "tblTutorials",
                        principalColumn: "TutorialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblArticles_TutorialId",
                table: "tblArticles",
                column: "TutorialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblArticles");

            migrationBuilder.DropTable(
                name: "tblTutorials");
        }
    }
}
