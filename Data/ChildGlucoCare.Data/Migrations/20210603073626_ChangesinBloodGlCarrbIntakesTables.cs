using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class ChangesinBloodGlCarrbIntakesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SuggestedDoseInsulin",
                table: "CarbohydrateIntakes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SuggestedCorrectionDoseInsulin",
                table: "BloodGlucoses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuggestedDoseInsulin",
                table: "CarbohydrateIntakes");

            migrationBuilder.DropColumn(
                name: "SuggestedCorrectionDoseInsulin",
                table: "BloodGlucoses");
        }
    }
}
