using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class M04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Candidate_CandidateId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CandidateId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Cellphone",
                table: "Candidate",
                newName: "UserId");

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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Candidate",
                newName: "Cellphone");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_CandidateId",
                table: "User",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Candidate_CandidateId",
                table: "User",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
