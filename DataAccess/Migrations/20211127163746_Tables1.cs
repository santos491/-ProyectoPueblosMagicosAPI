using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Tables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artesanoDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Apellido_Paterno = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Apellido_Materno = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Fecha_Registro = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Nombre_Negocio = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artesanoDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "restaurantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Restaurante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono_Restaurante = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Descripcion_Menu = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    Direccion_Restaurante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Municipio_Restaurante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productosArtesanias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtesanoDataId = table.Column<int>(type: "int", nullable: false),
                    Nombre_Artesania = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Materia_de_Elaboracion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Default = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productosArtesanias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productosArtesanias_artesanoDatas_ArtesanoDataId",
                        column: x => x.ArtesanoDataId,
                        principalTable: "artesanoDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productosArtesanias_ArtesanoDataId",
                table: "productosArtesanias",
                column: "ArtesanoDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productosArtesanias");

            migrationBuilder.DropTable(
                name: "restaurantes");

            migrationBuilder.DropTable(
                name: "artesanoDatas");
        }
    }
}
