using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class AddInsulinsAndInsulinInjections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodImageUrl",
                table: "Foods");

            migrationBuilder.CreateTable(
                name: "Insulins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsulinType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Onset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypicalActivityProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insulins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsulinInjections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsulinDose = table.Column<double>(type: "float", nullable: false),
                    Hour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsItForMeal = table.Column<bool>(type: "bit", nullable: false),
                    InsulinId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsulinInjections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsulinInjections_Insulins_InsulinId",
                        column: x => x.InsulinId,
                        principalTable: "Insulins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InsulinInjections_InsulinId",
                table: "InsulinInjections",
                column: "InsulinId");

            migrationBuilder.CreateIndex(
                name: "IX_InsulinInjections_IsDeleted",
                table: "InsulinInjections",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Insulins_IsDeleted",
                table: "Insulins",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsulinInjections");

            migrationBuilder.DropTable(
                name: "Insulins");

            migrationBuilder.AddColumn<string>(
                name: "FoodImageUrl",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
