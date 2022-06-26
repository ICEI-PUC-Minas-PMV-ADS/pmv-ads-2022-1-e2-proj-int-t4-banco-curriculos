using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class fkcandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_User_UserId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_UserId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Candidate");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_UserId",
                table: "Candidate",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_User_UserId",
                table: "Candidate",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_User_UserId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_UserId",
                table: "Candidate");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Candidate",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_UserId",
                table: "Candidate",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_User_UserId",
                table: "Candidate",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
