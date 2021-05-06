using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class inicialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Linkdin = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Lattes = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    Sexo = table.Column<string>(maxLength: 10, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: true),
                    Endereco = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "Text", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal", nullable: false),
                    TipoDoProduto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipoDeConteudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoDeConteudos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "classificados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classificados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_classificados_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_classificados_produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "conteudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeConteudoId = table.Column<int>(nullable: false),
                    AutorId = table.Column<int>(nullable: false),
                    DataDoCadastro = table.Column<DateTime>(type: "DATE", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    Texto = table.Column<string>(type: "text", nullable: true),
                    LinkImagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conteudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_conteudos_autores_AutorId",
                        column: x => x.AutorId,
                        principalTable: "autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conteudos_tipoDeConteudos_TipoDeConteudoId",
                        column: x => x.TipoDeConteudoId,
                        principalTable: "tipoDeConteudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classificados_ClienteId",
                table: "classificados",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_classificados_ProdutoId",
                table: "classificados",
                column: "ProdutoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_conteudos_AutorId",
                table: "conteudos",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_conteudos_TipoDeConteudoId",
                table: "conteudos",
                column: "TipoDeConteudoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classificados");

            migrationBuilder.DropTable(
                name: "conteudos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "autores");

            migrationBuilder.DropTable(
                name: "tipoDeConteudos");
        }
    }
}
