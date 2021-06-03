using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class ChangeCarbsIntakeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentGlucoseLevel",
                table: "CarbohydrateIntakes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CurrentGlucoseLevel",
                table: "CarbohydrateIntakes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
