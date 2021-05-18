using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class AddFoodCarbohydrateIntakeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GramsPerBreadUnit = table.Column<int>(type: "int", nullable: false),
                    GlycemicIndex = table.Column<int>(type: "int", nullable: false),
                    CarbohydratePer100Grams = table.Column<double>(type: "float", nullable: false),
                    FatPer100Grams = table.Column<double>(type: "float", nullable: false),
                    CaloriesPer100Grams = table.Column<double>(type: "float", nullable: false),
                    FoodCarbohydrateIntakeId = table.Column<int>(type: "int", nullable: false),
                    FoodType = table.Column<int>(type: "int", nullable: false),
                    FoodImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCarbohydrateIntakes",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CarbohydrateIntakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCarbohydrateIntakes", x => new { x.CarbohydrateIntakeId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_FoodCarbohydrateIntakes_CarbohidrateIntakes_CarbohydrateIntakeId",
                        column: x => x.CarbohydrateIntakeId,
                        principalTable: "CarbohidrateIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodCarbohydrateIntakes_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_IsDeleted",
                table: "Food",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCarbohydrateIntakes_FoodId",
                table: "FoodCarbohydrateIntakes",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCarbohydrateIntakes");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloriesPer100Grams = table.Column<double>(type: "float", nullable: false),
                    CarbohydrateIntakeId = table.Column<int>(type: "int", nullable: true),
                    CarbohydratePer100Grams = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FatPer100Grams = table.Column<double>(type: "float", nullable: false),
                    FoodImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodType = table.Column<int>(type: "int", nullable: false),
                    GlycemicIndex = table.Column<int>(type: "int", nullable: false),
                    GramsPerBreadUnit = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_CarbohidrateIntakes_CarbohydrateIntakeId",
                        column: x => x.CarbohydrateIntakeId,
                        principalTable: "CarbohidrateIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CarbohydrateIntakeId",
                table: "Foods",
                column: "CarbohydrateIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_IsDeleted",
                table: "Foods",
                column: "IsDeleted");
        }
    }
}
