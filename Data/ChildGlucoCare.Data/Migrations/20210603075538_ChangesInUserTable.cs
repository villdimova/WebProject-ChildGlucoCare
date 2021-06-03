using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class ChangesInUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsulinSensibility",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<double>(
                name: "InsulinSensitivity",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsulinSensitivity",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<decimal>(
                name: "InsulinSensibility",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
