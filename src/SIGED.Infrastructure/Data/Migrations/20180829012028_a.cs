using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGED.Infrastructure.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Endereco",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstudanteId",
                table: "Endereco",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EstudanteId",
                table: "Endereco",
                column: "EstudanteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Estudante_EstudanteId",
                table: "Endereco",
                column: "EstudanteId",
                principalTable: "Estudante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Estudante_EstudanteId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_EstudanteId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "EstudanteId",
                table: "Endereco");
        }
    }
}
