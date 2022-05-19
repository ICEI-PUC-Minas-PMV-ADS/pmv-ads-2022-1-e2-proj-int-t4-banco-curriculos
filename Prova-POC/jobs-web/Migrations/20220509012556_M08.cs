using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class M08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "ProfessionalExperience");

            migrationBuilder.DropColumn(
                name: "TypeOfJob",
                table: "ProfessionalExperience");

            migrationBuilder.AddColumn<int>(
                name: "JobType",
                table: "ProfessionalExperience",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobType",
                table: "ProfessionalExperience");

            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "ProfessionalExperience",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfJob",
                table: "ProfessionalExperience",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
