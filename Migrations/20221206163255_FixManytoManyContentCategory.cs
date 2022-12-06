using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpboolflix.Migrations
{
    /// <inheritdoc />
    public partial class FixManytoManyContentCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casts_Content_ContentId",
                table: "Casts");

            migrationBuilder.DropIndex(
                name: "IX_Casts_ContentId",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "Casts");

            migrationBuilder.CreateTable(
                name: "CastContent",
                columns: table => new
                {
                    CastsId = table.Column<int>(type: "int", nullable: false),
                    ContentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastContent", x => new { x.CastsId, x.ContentsId });
                    table.ForeignKey(
                        name: "FK_CastContent_Casts_CastsId",
                        column: x => x.CastsId,
                        principalTable: "Casts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastContent_Content_ContentsId",
                        column: x => x.ContentsId,
                        principalTable: "Content",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastContent_ContentsId",
                table: "CastContent",
                column: "ContentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastContent");

            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "Casts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Casts_ContentId",
                table: "Casts",
                column: "ContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Casts_Content_ContentId",
                table: "Casts",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "Id");
        }
    }
}
