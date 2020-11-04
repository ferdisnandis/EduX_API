using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduX_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instituicao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Logradouro = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Permissao = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objetivo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    IdCategoria = table.Column<Guid>(nullable: false),
                    UrlImagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objetivo_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: false),
                    IdInstituicao = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_Instituicao_IdInstituicao",
                        column: x => x.IdInstituicao,
                        principalTable: "Instituicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataUltimoAcesso = table.Column<DateTime>(nullable: false),
                    IdPerfil = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_IdPerfil",
                        column: x => x.IdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    IdCurso = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turma_Curso_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dica",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Texto = table.Column<string>(type: "varchar(255)", nullable: true),
                    Imagem = table.Column<string>(type: "varchar(255)", nullable: true),
                    IdUsuario = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dica_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoTurma",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Matricula = table.Column<string>(nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: false),
                    IdTurma = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoTurma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoTurma_Turma_IdTurma",
                        column: x => x.IdTurma,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoTurma_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorTurma",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    IdUsuario = table.Column<Guid>(nullable: false),
                    IdTurma = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorTurma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessorTurma_Turma_IdTurma",
                        column: x => x.IdTurma,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessorTurma_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curtida",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: false),
                    IdDica = table.Column<Guid>(nullable: false),
                    DicaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curtida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curtida_Dica_DicaId",
                        column: x => x.DicaId,
                        principalTable: "Dica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Curtida_Dica_IdDica",
                        column: x => x.IdDica,
                        principalTable: "Dica",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Curtida_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObjetivoAluno",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DataAlcancado = table.Column<DateTime>(nullable: false),
                    IdAlunoTurma = table.Column<Guid>(nullable: false),
                    IdObjetivo = table.Column<Guid>(nullable: false),
                    UrlImagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetivoAluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjetivoAluno_AlunoTurma_IdAlunoTurma",
                        column: x => x.IdAlunoTurma,
                        principalTable: "AlunoTurma",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ObjetivoAluno_Objetivo_IdObjetivo",
                        column: x => x.IdObjetivo,
                        principalTable: "Objetivo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoTurma_IdTurma",
                table: "AlunoTurma",
                column: "IdTurma");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoTurma_IdUsuario",
                table: "AlunoTurma",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_IdInstituicao",
                table: "Curso",
                column: "IdInstituicao");

            migrationBuilder.CreateIndex(
                name: "IX_Curtida_DicaId",
                table: "Curtida",
                column: "DicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Curtida_IdDica",
                table: "Curtida",
                column: "IdDica");

            migrationBuilder.CreateIndex(
                name: "IX_Curtida_IdUsuario",
                table: "Curtida",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Dica_IdUsuario",
                table: "Dica",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Objetivo_IdCategoria",
                table: "Objetivo",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetivoAluno_IdAlunoTurma",
                table: "ObjetivoAluno",
                column: "IdAlunoTurma");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetivoAluno_IdObjetivo",
                table: "ObjetivoAluno",
                column: "IdObjetivo");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorTurma_IdTurma",
                table: "ProfessorTurma",
                column: "IdTurma");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorTurma_IdUsuario",
                table: "ProfessorTurma",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_IdCurso",
                table: "Turma",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdPerfil",
                table: "Usuario",
                column: "IdPerfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curtida");

            migrationBuilder.DropTable(
                name: "ObjetivoAluno");

            migrationBuilder.DropTable(
                name: "ProfessorTurma");

            migrationBuilder.DropTable(
                name: "Dica");

            migrationBuilder.DropTable(
                name: "AlunoTurma");

            migrationBuilder.DropTable(
                name: "Objetivo");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Instituicao");
        }
    }
}
