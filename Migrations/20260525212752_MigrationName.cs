using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenFinalWeb.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pregunta",
                columns: table => new
                {
                    idPregunta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enunciado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fueResuelta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregunta", x => x.idPregunta);
                });

            migrationBuilder.CreateTable(
                name: "Respuesta",
                columns: table => new
                {
                    idRespuesta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idPregunta = table.Column<int>(type: "int", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respuesta", x => x.idRespuesta);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pregunta");

            migrationBuilder.DropTable(
                name: "Respuesta");
        }
    }
}
