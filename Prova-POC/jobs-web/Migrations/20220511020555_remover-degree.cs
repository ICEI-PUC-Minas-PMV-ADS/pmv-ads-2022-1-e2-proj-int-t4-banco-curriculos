using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Migrations
{
    public partial class removerdegree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Educations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
