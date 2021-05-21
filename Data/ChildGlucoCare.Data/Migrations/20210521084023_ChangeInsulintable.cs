using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class ChangeInsulintable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypicalActivityProfileUrl",
                table: "Insulins",
                newName: "Taken");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Taken",
                table: "Insulins",
                newName: "TypicalActivityProfileUrl");
        }
    }
}
