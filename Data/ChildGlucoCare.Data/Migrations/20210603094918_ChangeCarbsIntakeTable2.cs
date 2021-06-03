using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class ChangeCarbsIntakeTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalBeu",
                table: "CarbohydrateIntakes",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalBeu",
                table: "CarbohydrateIntakes",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
