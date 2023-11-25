using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AraujoMaterialConstrucao.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTileBrandeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Tile",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tile_BrandId",
                table: "Tile",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tile_Brand_BrandId",
                table: "Tile",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tile_Brand_BrandId",
                table: "Tile");

            migrationBuilder.DropIndex(
                name: "IX_Tile_BrandId",
                table: "Tile");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Tile");
        }
    }
}
