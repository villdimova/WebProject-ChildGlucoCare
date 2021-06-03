using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class ChangesInCarbsIntakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CurrentGlucoseLevel",
                table: "CarbohydrateIntakes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "CurrentGlucoseLevel",
                table: "BloodGlucoses",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentGlucoseLevel",
                table: "CarbohydrateIntakes");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentGlucoseLevel",
                table: "BloodGlucoses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
