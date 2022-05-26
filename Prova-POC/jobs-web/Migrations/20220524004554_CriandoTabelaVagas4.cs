using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class CriandoTabelaVagas4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_User_UserId",
                table: "Vagas");

            migrationBuilder.DropIndex(
                name: "IX_Vagas_UserId",
                table: "Vagas");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Vagas",
                newName: "EmpresaId");

            migrationBuilder.AddColumn<int>(
                name: "VagasId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_EmpresaId",
                table: "Vagas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_VagasId",
                table: "User",
                column: "VagasId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Vagas_VagasId",
                table: "User",
                column: "VagasId",
                principalTable: "Vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vagas_Empresa_EmpresaId",
                table: "Vagas",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Vagas_VagasId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_Empresa_EmpresaId",
                table: "Vagas");

            migrationBuilder.DropIndex(
                name: "IX_Vagas_EmpresaId",
                table: "Vagas");

            migrationBuilder.DropIndex(
                name: "IX_User_VagasId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "VagasId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Vagas",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_UserId",
                table: "Vagas",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vagas_User_UserId",
                table: "Vagas",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
