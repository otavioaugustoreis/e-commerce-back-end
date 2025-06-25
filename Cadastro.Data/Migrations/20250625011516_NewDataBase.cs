using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastro.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_LOGIN",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DhInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LOGIN", x => x.PkId);
                });

            migrationBuilder.CreateTable(
                name: "TB_PAGAMENTO",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    PagamentoStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrQrCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NrCartaoMascarado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcelas = table.Column<int>(type: "int", nullable: true),
                    DhInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PAGAMENTO", x => x.PkId);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DsNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    NrValor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DhInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.PkId);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DsNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrIdade = table.Column<int>(type: "int", nullable: false),
                    ds_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DhInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.PkId);
                });

            migrationBuilder.CreateTable(
                name: "TB_PEDIDO",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUsuario = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FkPagamento = table.Column<int>(type: "int", nullable: false),
                    NrValor = table.Column<double>(type: "float", nullable: false),
                    DhInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PEDIDO", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_TB_PEDIDO_TB_PAGAMENTO_FkPagamento",
                        column: x => x.FkPagamento,
                        principalTable: "TB_PAGAMENTO",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PEDIDO_TB_USUARIO_FkUsuario",
                        column: x => x.FkUsuario,
                        principalTable: "TB_USUARIO",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_NOTIFICACAO",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DsMensagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FkPedido = table.Column<int>(type: "int", nullable: false),
                    DhInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_NOTIFICACAO", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_TB_NOTIFICACAO_TB_PEDIDO_FkPedido",
                        column: x => x.FkPedido,
                        principalTable: "TB_PEDIDO",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_PEDIDOITEM",
                columns: table => new
                {
                    PkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkPedido = table.Column<int>(type: "int", nullable: false),
                    FkProduto = table.Column<int>(type: "int", nullable: false),
                    NrQuantidade = table.Column<int>(type: "int", nullable: false),
                    DhInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PEDIDOITEM", x => x.PkId);
                    table.ForeignKey(
                        name: "FK_TB_PEDIDOITEM_TB_PEDIDO_FkPedido",
                        column: x => x.FkPedido,
                        principalTable: "TB_PEDIDO",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PEDIDOITEM_TB_PRODUTO_FkProduto",
                        column: x => x.FkProduto,
                        principalTable: "TB_PRODUTO",
                        principalColumn: "PkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_NOTIFICACAO_FkPedido",
                table: "TB_NOTIFICACAO",
                column: "FkPedido");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PEDIDO_FkPagamento",
                table: "TB_PEDIDO",
                column: "FkPagamento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PEDIDO_FkUsuario",
                table: "TB_PEDIDO",
                column: "FkUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PEDIDOITEM_FkPedido",
                table: "TB_PEDIDOITEM",
                column: "FkPedido");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PEDIDOITEM_FkProduto",
                table: "TB_PEDIDOITEM",
                column: "FkProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_LOGIN");

            migrationBuilder.DropTable(
                name: "TB_NOTIFICACAO");

            migrationBuilder.DropTable(
                name: "TB_PEDIDOITEM");

            migrationBuilder.DropTable(
                name: "TB_PEDIDO");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "TB_PAGAMENTO");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");
        }
    }
}
