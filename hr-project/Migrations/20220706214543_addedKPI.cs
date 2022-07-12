using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hr_project.Migrations
{
    public partial class addedKPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KPI",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KPI",
                table: "Employees");
        }
    }
}
