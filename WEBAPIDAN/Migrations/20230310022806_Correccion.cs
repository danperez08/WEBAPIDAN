using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPIDAN.Migrations
{
    /// <inheritdoc />
    public partial class Correccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teclados_Marcas_MarcaId",
                table: "Teclados");

            migrationBuilder.DropForeignKey(
                name: "FK_Teclados_Modelos_ModeloId",
                table: "Teclados");

            migrationBuilder.DropIndex(
                name: "IX_Teclados_MarcaId",
                table: "Teclados");

            migrationBuilder.DropIndex(
                name: "IX_Teclados_ModeloId",
                table: "Teclados");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Teclados");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "Teclados");

            migrationBuilder.AlterColumn<string>(
                name: "TipoConexion",
                table: "Teclados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Modelos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TecladoId",
                table: "Modelos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreMarca",
                table: "Marcas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TecladoId",
                table: "Marcas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_TecladoId",
                table: "Modelos",
                column: "TecladoId");

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_TecladoId",
                table: "Marcas",
                column: "TecladoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marcas_Teclados_TecladoId",
                table: "Marcas",
                column: "TecladoId",
                principalTable: "Teclados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Teclados_TecladoId",
                table: "Modelos",
                column: "TecladoId",
                principalTable: "Teclados",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marcas_Teclados_TecladoId",
                table: "Marcas");

            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Teclados_TecladoId",
                table: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_TecladoId",
                table: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Marcas_TecladoId",
                table: "Marcas");

            migrationBuilder.DropColumn(
                name: "TecladoId",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "TecladoId",
                table: "Marcas");

            migrationBuilder.AlterColumn<string>(
                name: "TipoConexion",
                table: "Teclados",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Teclados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "Teclados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Modelos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NombreMarca",
                table: "Marcas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Teclados_MarcaId",
                table: "Teclados",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Teclados_ModeloId",
                table: "Teclados",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teclados_Marcas_MarcaId",
                table: "Teclados",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teclados_Modelos_ModeloId",
                table: "Teclados",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
