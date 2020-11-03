using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduX_API.Migrations
{
    public partial class EduXDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdObjetivo",
                table: "ObjetivoAluno",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ObjetivoAluno_IdObjetivo",
                table: "ObjetivoAluno",
                column: "IdObjetivo");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjetivoAluno_Objetivo_IdObjetivo",
                table: "ObjetivoAluno",
                column: "IdObjetivo",
                principalTable: "Objetivo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjetivoAluno_Objetivo_IdObjetivo",
                table: "ObjetivoAluno");

            migrationBuilder.DropIndex(
                name: "IX_ObjetivoAluno_IdObjetivo",
                table: "ObjetivoAluno");

            migrationBuilder.DropColumn(
                name: "IdObjetivo",
                table: "ObjetivoAluno");
        }
    }
}
