using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class _010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperience");

            migrationBuilder.DropIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperience",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations",
                column: "CandidateId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperience");

            migrationBuilder.DropIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperience",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations",
                column: "CandidateId");
        }
    }
}
