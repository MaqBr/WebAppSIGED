using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculosBasal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculosBasal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaracterizacoesAreas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoArea = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    TipoClima = table.Column<string>(nullable: true),
                    TipoSolo = table.Column<string>(nullable: true),
                    DescricaoAmbiente = table.Column<string>(nullable: true),
                    TamanhoPropriedade = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracterizacoesAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColetasAmostras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataColeta = table.Column<DateTime>(nullable: false),
                    Profundidade = table.Column<int>(nullable: false),
                    Armazenamento = table.Column<string>(nullable: true),
                    TempodeRepouso = table.Column<int>(nullable: false),
                    PesoAmostra = table.Column<double>(nullable: false),
                    TipodeTratamento = table.Column<string>(nullable: true),
                    TipodeEcossistema = table.Column<string>(nullable: true),
                    Sazonalidade = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColetasAmostras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MateriaisEquipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MateriaisUtilizados = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaisEquipamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pesquisadores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    InstituicaoDeEnsino = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesquisadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessamentoAmostras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Peneira = table.Column<int>(nullable: false),
                    Solucoes = table.Column<string>(nullable: true),
                    TipodeArmazenamento = table.Column<string>(nullable: true),
                    Refrigeracao = table.Column<double>(nullable: false),
                    PeriodoIncubacao = table.Column<DateTime>(nullable: false),
                    DescricaoProcedimento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessamentoAmostras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculosBasal");

            migrationBuilder.DropTable(
                name: "CaracterizacoesAreas");

            migrationBuilder.DropTable(
                name: "ColetasAmostras");

            migrationBuilder.DropTable(
                name: "MateriaisEquipamentos");

            migrationBuilder.DropTable(
                name: "Pesquisadores");

            migrationBuilder.DropTable(
                name: "ProcessamentoAmostras");
        }
    }
}
