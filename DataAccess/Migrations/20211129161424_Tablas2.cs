using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Tablas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productosArtesanias_artesanoDatas_ArtesanoDataId",
                table: "productosArtesanias");

            migrationBuilder.DropIndex(
                name: "IX_productosArtesanias_ArtesanoDataId",
                table: "productosArtesanias");

            migrationBuilder.DropColumn(
                name: "ArtesanoDataId",
                table: "productosArtesanias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtesanoDataId",
                table: "productosArtesanias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productosArtesanias_ArtesanoDataId",
                table: "productosArtesanias",
                column: "ArtesanoDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_productosArtesanias_artesanoDatas_ArtesanoDataId",
                table: "productosArtesanias",
                column: "ArtesanoDataId",
                principalTable: "artesanoDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
