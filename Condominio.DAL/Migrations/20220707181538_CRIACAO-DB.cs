using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Condominio.DAL.Migrations
{
    public partial class CRIACAODB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Funcoes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Funcoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Meses",
                columns: table => new
                {
                    MesId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Meses", x => x.MesId);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Usuarios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimeiroAcesso = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Tb_Funcoes_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Tb_Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Alugueis",
                columns: table => new
                {
                    AluguelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MesId = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Alugueis", x => x.AluguelId);
                    table.ForeignKey(
                        name: "FK_Tb_Alugueis_Tb_Meses_MesId",
                        column: x => x.MesId,
                        principalTable: "Tb_Meses",
                        principalColumn: "MesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_HistoricoRecursos",
                columns: table => new
                {
                    HistoricoRecursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    MesId = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_HistoricoRecursos", x => x.HistoricoRecursoId);
                    table.ForeignKey(
                        name: "FK_Tb_HistoricoRecursos_Tb_Meses_MesId",
                        column: x => x.MesId,
                        principalTable: "Tb_Meses",
                        principalColumn: "MesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Tb_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Tb_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Tb_Funcoes_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Tb_Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Tb_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Tb_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Apartamentos",
                columns: table => new
                {
                    ApartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Andar = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoradorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProprietarioId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Apartamentos", x => x.ApartamentoId);
                    table.ForeignKey(
                        name: "FK_Tb_Apartamentos_Tb_Usuarios_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tb_Apartamentos_Tb_Usuarios_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tb_Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Eventos", x => x.EventoId);
                    table.ForeignKey(
                        name: "FK_Tb_Eventos_Tb_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Servicos",
                columns: table => new
                {
                    ServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Servicos", x => x.ServicoId);
                    table.ForeignKey(
                        name: "FK_Tb_Servicos_Tb_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Veiculos", x => x.VeiculoId);
                    table.ForeignKey(
                        name: "FK_Tb_Veiculos_Tb_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pagamentos",
                columns: table => new
                {
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AluguelId = table.Column<int>(type: "int", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pagamentos", x => x.PagamentoId);
                    table.ForeignKey(
                        name: "FK_Tb_Pagamentos_Tb_Alugueis_AluguelId",
                        column: x => x.AluguelId,
                        principalTable: "Tb_Alugueis",
                        principalColumn: "AluguelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Pagamentos_Tb_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Tb_Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_ServicoPredios",
                columns: table => new
                {
                    ServicoPredioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicoId = table.Column<int>(type: "int", nullable: false),
                    DataExecucao = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_ServicoPredios", x => x.ServicoPredioId);
                    table.ForeignKey(
                        name: "FK_Tb_ServicoPredios_Tb_Servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Tb_Servicos",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tb_Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33d5d36e-332c-42cb-a61c-5d1a80826cd0", "fd7fc958-1c48-45be-ae07-2b294ad4bb9d", "Síndico do prédio", "Sindico", "SINDICO" },
                    { "380277a8-fc49-4d8b-a4b7-7cb9c826ff30", "6fbca80f-1acf-407c-8fa1-20d62330e0a9", "Morador do prédio", "Morador", "MORADOR" },
                    { "d5715c01-b0fc-4cc0-b82f-781f8367f889", "bf28c22c-3315-4ca8-b71f-69811c23b689", "Administrador do prédio", "Adminstrador", "Administrador" }
                });

            migrationBuilder.InsertData(
                table: "Tb_Meses",
                columns: new[] { "MesId", "Nome" },
                values: new object[,]
                {
                    { 1, "Janeiro" },
                    { 2, "Fevereiro" },
                    { 3, "Março" },
                    { 4, "Abril" },
                    { 5, "Maio" },
                    { 6, "Junho" },
                    { 7, "Julho" },
                    { 8, "Agosto" },
                    { 9, "Setembro" },
                    { 10, "Outubro" },
                    { 11, "Novembro" },
                    { 12, "Dezembro" }
                });

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
                name: "IX_Tb_Alugueis_MesId",
                table: "Tb_Alugueis",
                column: "MesId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Apartamentos_MoradorId",
                table: "Tb_Apartamentos",
                column: "MoradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Apartamentos_ProprietarioId",
                table: "Tb_Apartamentos",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Eventos_UsuarioId",
                table: "Tb_Eventos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Tb_Funcoes",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_HistoricoRecursos_MesId",
                table: "Tb_HistoricoRecursos",
                column: "MesId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Meses_Nome",
                table: "Tb_Meses",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pagamentos_AluguelId",
                table: "Tb_Pagamentos",
                column: "AluguelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pagamentos_UsuarioId",
                table: "Tb_Pagamentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_ServicoPredios_ServicoId",
                table: "Tb_ServicoPredios",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Servicos_UsuarioId",
                table: "Tb_Servicos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Tb_Usuarios",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Usuarios_CPF",
                table: "Tb_Usuarios",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Tb_Usuarios",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Veiculos_Placa",
                table: "Tb_Veiculos",
                column: "Placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Veiculos_UsuarioId",
                table: "Tb_Veiculos",
                column: "UsuarioId");
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
                name: "Tb_Apartamentos");

            migrationBuilder.DropTable(
                name: "Tb_Eventos");

            migrationBuilder.DropTable(
                name: "Tb_HistoricoRecursos");

            migrationBuilder.DropTable(
                name: "Tb_Pagamentos");

            migrationBuilder.DropTable(
                name: "Tb_ServicoPredios");

            migrationBuilder.DropTable(
                name: "Tb_Veiculos");

            migrationBuilder.DropTable(
                name: "Tb_Funcoes");

            migrationBuilder.DropTable(
                name: "Tb_Alugueis");

            migrationBuilder.DropTable(
                name: "Tb_Servicos");

            migrationBuilder.DropTable(
                name: "Tb_Meses");

            migrationBuilder.DropTable(
                name: "Tb_Usuarios");
        }
    }
}
