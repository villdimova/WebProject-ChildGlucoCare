using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class CorrectTableBllodGlucose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiabetesDiaryId",
                table: "BloodGlucoses");

            migrationBuilder.AlterColumn<int>(
                name: "DiabeticDiaryId",
                table: "BloodGlucoses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DiabeticDiaryId",
                table: "BloodGlucoses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DiabetesDiaryId",
                table: "BloodGlucoses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
