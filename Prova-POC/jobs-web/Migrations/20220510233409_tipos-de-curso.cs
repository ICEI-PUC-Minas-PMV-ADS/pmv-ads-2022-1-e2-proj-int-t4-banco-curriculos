using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class tiposdecurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperience");

            migrationBuilder.DropIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations");

            migrationBuilder.AlterColumn<int>(
                name: "Course",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseType",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperience",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations",
                column: "CandidateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperience");

            migrationBuilder.DropIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "CourseType",
                table: "Educations");

            migrationBuilder.AlterColumn<string>(
                name: "Course",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
