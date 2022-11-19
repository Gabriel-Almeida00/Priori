using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Priori_DADOS.Migrations
{
    public partial class criacaoBancoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblAgente",
                columns: table => new
                {
                    agente_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(maxLength: 50, nullable: false),
                    cpf = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(maxLength: 15, nullable: false),
                    salario = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    data_contratacao = table.Column<DateTime>(maxLength: 15, nullable: false),
                    data_demissao = table.Column<DateTime>(maxLength: 15, nullable: false),
                    estado = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAgente", x => x.agente_id);
                });

            migrationBuilder.CreateTable(
                name: "tblTipoInvestidor",
                columns: table => new
                {
                    id_tipoinvestidor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_categoria = table.Column<string>(maxLength: 50, nullable: false),
                    descricao_categoria = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTipoInvestidor", x => x.id_tipoinvestidor);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Funcoes_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblClientes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    nome = table.Column<string>(maxLength: 50, nullable: false),
                    id_tipoinvestidor = table.Column<int>(nullable: false),
                    tipoInvestidorid_tipoinvestidor = table.Column<int>(nullable: true),
                    id_agente = table.Column<int>(nullable: false),
                    cpf = table.Column<string>(maxLength: 15, nullable: false),
                    emailCliente = table.Column<string>(maxLength: 30, nullable: false),
                    senha = table.Column<string>(maxLength: 15, nullable: false),
                    endereco = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(maxLength: 15, nullable: false),
                    data_adesao = table.Column<DateTime>(maxLength: 15, nullable: false),
                    estado = table.Column<string>(maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblClientes_tblAgente_id_agente",
                        column: x => x.id_agente,
                        principalTable: "tblAgente",
                        principalColumn: "agente_id");
                    table.ForeignKey(
                        name: "FK_tblClientes_tblTipoInvestidor_tipoInvestidorid_tipoinvestidor",
                        column: x => x.tipoInvestidorid_tipoinvestidor,
                        principalTable: "tblTipoInvestidor",
                        principalColumn: "id_tipoinvestidor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_tblClientes_UserId",
                        column: x => x.UserId,
                        principalTable: "tblClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_tblClientes_UserId",
                        column: x => x.UserId,
                        principalTable: "tblClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Funcoes_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_tblClientes_UserId",
                        column: x => x.UserId,
                        principalTable: "tblClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_tblClientes_UserId",
                        column: x => x.UserId,
                        principalTable: "tblClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCarteiraInvestimento",
                columns: table => new
                {
                    id_carteira = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<string>(nullable: false),
                    id_investimento = table.Column<int>(nullable: false),
                    data_efetuacao = table.Column<DateTime>(maxLength: 50, nullable: false),
                    valor_aplicado = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    tempo_aplicacao = table.Column<int>(maxLength: 35, nullable: false),
                    duracao = table.Column<DateTime>(maxLength: 15, nullable: false),
                    saldo = table.Column<decimal>(type: "decimal(5,2)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCarteiraInvestimento", x => x.id_carteira);
                    table.ForeignKey(
                        name: "FK_tblCarteiraInvestimento_tblClientes_id_cliente",
                        column: x => x.id_cliente,
                        principalTable: "tblClientes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tblInvestimento",
                columns: table => new
                {
                    id_investimento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_tipoInvestidor = table.Column<int>(nullable: false),
                    id_carteira = table.Column<int>(nullable: false),
                    nome = table.Column<int>(maxLength: 50, nullable: false),
                    tipo_investimento = table.Column<string>(maxLength: 15, nullable: false),
                    rentabilidade = table.Column<string>(maxLength: 15, nullable: false),
                    valor_minimo = table.Column<decimal>(type: "decimal(5,2)", maxLength: 15, nullable: false),
                    tempo_minimo = table.Column<int>(maxLength: 15, nullable: false),
                    descricao = table.Column<string>(maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblInvestimento", x => x.id_investimento);
                    table.ForeignKey(
                        name: "FK_tblInvestimento_tblCarteiraInvestimento_id_carteira",
                        column: x => x.id_carteira,
                        principalTable: "tblCarteiraInvestimento",
                        principalColumn: "id_carteira");
                    table.ForeignKey(
                        name: "FK_tblInvestimento_tblTipoInvestidor_id_tipoInvestidor",
                        column: x => x.id_tipoInvestidor,
                        principalTable: "tblTipoInvestidor",
                        principalColumn: "id_tipoinvestidor");
                });

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[] { "8991b961-c19d-47db-b730-e5c2fbfdd22f", "0948e857-878e-426b-a098-b1b1cccdaafc", "Administrador do sistema", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[] { "f2916251-d70f-4c28-b0aa-cc2601010280", "027ffdf5-95b2-4a04-b8b6-f7c849003ef9", "Usuário do sistema", "Usuario", "USUARIO" });

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[] { "a37c07f3-4669-431c-9d09-fff31016eea8", "725a69e3-1d6d-4f26-a69c-ef10a8353fb4", "Agente do sistema", "Agente", "AGENTE" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Funcoes",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblCarteiraInvestimento_id_cliente",
                table: "tblCarteiraInvestimento",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "tblClientes",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tblClientes",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblClientes_id_agente",
                table: "tblClientes",
                column: "id_agente");

            migrationBuilder.CreateIndex(
                name: "IX_tblClientes_tipoInvestidorid_tipoinvestidor",
                table: "tblClientes",
                column: "tipoInvestidorid_tipoinvestidor");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvestimento_id_carteira",
                table: "tblInvestimento",
                column: "id_carteira");

            migrationBuilder.CreateIndex(
                name: "IX_tblInvestimento_id_tipoInvestidor",
                table: "tblInvestimento",
                column: "id_tipoInvestidor");

            migrationBuilder.CreateIndex(
                name: "IX_tblTipoInvestidor_nome_categoria",
                table: "tblTipoInvestidor",
                column: "nome_categoria",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tblInvestimento");

            migrationBuilder.DropTable(
                name: "Funcoes");

            migrationBuilder.DropTable(
                name: "tblCarteiraInvestimento");

            migrationBuilder.DropTable(
                name: "tblClientes");

            migrationBuilder.DropTable(
                name: "tblAgente");

            migrationBuilder.DropTable(
                name: "tblTipoInvestidor");
        }
    }
}
