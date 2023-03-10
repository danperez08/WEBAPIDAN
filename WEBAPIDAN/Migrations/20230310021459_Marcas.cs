using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPIDAN.Migrations
{
    /// <inheritdoc />
    public partial class Marcas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Teclados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMarca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teclados_MarcaId",
                table: "Teclados",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teclados_Marcas_MarcaId",
                table: "Teclados",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teclados_Marcas_MarcaId",
                table: "Teclados");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropIndex(
                name: "IX_Teclados_MarcaId",
                table: "Teclados");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Teclados");
        }
    }
}
