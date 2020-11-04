using Microsoft.EntityFrameworkCore.Migrations;

namespace EduX_API.Migrations
{
    public partial class NotNullNotaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Nota",
                table: "ObjetivoAluno",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Nota",
                table: "ObjetivoAluno",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);
        }
    }
}
