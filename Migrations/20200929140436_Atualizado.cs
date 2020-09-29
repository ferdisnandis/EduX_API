using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduX_API.Migrations
{
    public partial class Atualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Perfil_IdPerfil",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "IdPerfil",
                table: "Perfil");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Perfil",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Perfil_IdPerfil",
                table: "Usuario",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Perfil_IdPerfil",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Perfil");

            migrationBuilder.AddColumn<Guid>(
                name: "IdPerfil",
                table: "Perfil",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil",
                column: "IdPerfil");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Perfil_IdPerfil",
                table: "Usuario",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
