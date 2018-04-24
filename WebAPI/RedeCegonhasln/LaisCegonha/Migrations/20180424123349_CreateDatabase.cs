using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaisCegonha.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlturaUterina = table.Column<decimal>(nullable: false),
                    BatimentoCadiacoFetal = table.Column<decimal>(nullable: false),
                    DataConsulta = table.Column<DateTime>(nullable: false),
                    Diabetes = table.Column<string>(nullable: true),
                    EstadoNutricional = table.Column<string>(nullable: true),
                    Fumante = table.Column<string>(nullable: true),
                    Gravidez = table.Column<string>(nullable: true),
                    HoraConsulta = table.Column<string>(nullable: true),
                    MovitacaoFetal = table.Column<string>(nullable: true),
                    NumeroDeConsultas = table.Column<int>(nullable: false),
                    Obsidade = table.Column<string>(nullable: true),
                    PressaoArterial = table.Column<decimal>(nullable: false),
                    TempoGestacao = table.Column<string>(nullable: true),
                    TipoParto = table.Column<string>(nullable: true),
                    UsuariaAlcool = table.Column<string>(nullable: true),
                    UsuariaDrogas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Escolaridade = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    QuantFilhosMortos = table.Column<int>(nullable: false),
                    QuantFilhosVivos = table.Column<int>(nullable: false),
                    Rua = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Criancas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Apgar1 = table.Column<string>(nullable: true),
                    Apgar5 = table.Column<string>(nullable: true),
                    Declaracao = table.Column<int>(nullable: false),
                    IdMae = table.Column<int>(nullable: false),
                    MaeId = table.Column<int>(nullable: true),
                    Peso = table.Column<decimal>(nullable: false),
                    Sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criancas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criancas_Maes_MaeId",
                        column: x => x.MaeId,
                        principalTable: "Maes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaeConsultaPreNatal",
                columns: table => new
                {
                    IdMae = table.Column<int>(nullable: false),
                    IdConsultaPreNatal = table.Column<int>(nullable: false),
                    ConsultaPreNatalId = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    MaeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaeConsultaPreNatal", x => new { x.IdMae, x.IdConsultaPreNatal });
                    table.ForeignKey(
                        name: "FK_MaeConsultaPreNatal_Consultas_ConsultaPreNatalId",
                        column: x => x.ConsultaPreNatalId,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaeConsultaPreNatal_Maes_MaeId",
                        column: x => x.MaeId,
                        principalTable: "Maes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataParto = table.Column<DateTime>(nullable: false),
                    Horario = table.Column<string>(nullable: true),
                    IdMae = table.Column<int>(nullable: false),
                    LocalNasci = table.Column<string>(nullable: true),
                    MaeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partos_Maes_MaeId",
                        column: x => x.MaeId,
                        principalTable: "Maes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Criancas_MaeId",
                table: "Criancas",
                column: "MaeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaeConsultaPreNatal_ConsultaPreNatalId",
                table: "MaeConsultaPreNatal",
                column: "ConsultaPreNatalId");

            migrationBuilder.CreateIndex(
                name: "IX_MaeConsultaPreNatal_MaeId",
                table: "MaeConsultaPreNatal",
                column: "MaeId");

            migrationBuilder.CreateIndex(
                name: "IX_Partos_MaeId",
                table: "Partos",
                column: "MaeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Criancas");

            migrationBuilder.DropTable(
                name: "MaeConsultaPreNatal");

            migrationBuilder.DropTable(
                name: "Partos");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Maes");
        }
    }
}
