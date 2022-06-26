using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalExperiences_Candidate_CandidateId",
                table: "ProfessionalExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionalExperiences",
                table: "ProfessionalExperiences");

            migrationBuilder.RenameTable(
                name: "ProfessionalExperiences",
                newName: "ProfessionalExperience");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalExperiences_CandidateId",
                table: "ProfessionalExperience",
                newName: "IX_ProfessionalExperience_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionalExperience",
                table: "ProfessionalExperience",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CandidateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CandidateId",
                table: "Educations",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalExperience_Candidate_CandidateId",
                table: "ProfessionalExperience",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalExperience_Candidate_CandidateId",
                table: "ProfessionalExperience");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionalExperience",
                table: "ProfessionalExperience");

            migrationBuilder.RenameTable(
                name: "ProfessionalExperience",
                newName: "ProfessionalExperiences");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalExperience_CandidateId",
                table: "ProfessionalExperiences",
                newName: "IX_ProfessionalExperiences_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionalExperiences",
                table: "ProfessionalExperiences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalExperiences_Candidate_CandidateId",
                table: "ProfessionalExperiences",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
