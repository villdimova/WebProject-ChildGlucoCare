using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildGlucoCare.Data.Migrations
{
    public partial class CreateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiabeticDiaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabeticDiaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insulins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsulinType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsulinActionUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "BloodGlucoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentGlucoseLevel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodGlocoseStatus = table.Column<int>(type: "int", nullable: false),
                    DiabetesDiaryId = table.Column<int>(type: "int", nullable: false),
                    DiabeticDiaryId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGlucoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodGlucoses_DiabeticDiaries_DiabeticDiaryId",
                        column: x => x.DiabeticDiaryId,
                        principalTable: "DiabeticDiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarbohidrateIntakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    NeededInsulin = table.Column<int>(type: "int", nullable: false),
                    DiabeticDiaryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbohidrateIntakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarbohidrateIntakes_DiabeticDiaries_DiabeticDiaryId",
                        column: x => x.DiabeticDiaryId,
                        principalTable: "DiabeticDiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SportActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityLevel = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Hour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiabeticDiaryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportActivities_DiabeticDiaries_DiabeticDiaryId",
                        column: x => x.DiabeticDiaryId,
                        principalTable: "DiabeticDiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InjectedInsulins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsulinId = table.Column<int>(type: "int", nullable: false),
                    InsulinDose = table.Column<int>(type: "int", nullable: false),
                    InjectionTimeBeforeEating = table.Column<TimeSpan>(type: "time", nullable: false),
                    Hour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsulinRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiabeticDiaryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectedInsulins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjectedInsulins_DiabeticDiaries_DiabeticDiaryId",
                        column: x => x.DiabeticDiaryId,
                        principalTable: "DiabeticDiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InjectedInsulins_Insulins_InsulinId",
                        column: x => x.InsulinId,
                        principalTable: "Insulins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GramsPerBreadUnit = table.Column<int>(type: "int", nullable: false),
                    GlycemicIndex = table.Column<int>(type: "int", nullable: false),
                    CarbohydratePer100Grams = table.Column<double>(type: "float", nullable: false),
                    FatPer100Grams = table.Column<double>(type: "float", nullable: false),
                    CaloriesPer100Grams = table.Column<double>(type: "float", nullable: false),
                    CarbohydrateIntakeId = table.Column<int>(type: "int", nullable: true),
                    FoodType = table.Column<int>(type: "int", nullable: false),
                    FoodImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "IX_BloodGlucoses_DiabeticDiaryId",
                table: "BloodGlucoses",
                column: "DiabeticDiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodGlucoses_IsDeleted",
                table: "BloodGlucoses",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CarbohidrateIntakes_DiabeticDiaryId",
                table: "CarbohidrateIntakes",
                column: "DiabeticDiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_CarbohidrateIntakes_IsDeleted",
                table: "CarbohidrateIntakes",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DiabeticDiaries_IsDeleted",
                table: "DiabeticDiaries",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CarbohydrateIntakeId",
                table: "Foods",
                column: "CarbohydrateIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_IsDeleted",
                table: "Foods",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_InjectedInsulins_DiabeticDiaryId",
                table: "InjectedInsulins",
                column: "DiabeticDiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_InjectedInsulins_InsulinId",
                table: "InjectedInsulins",
                column: "InsulinId");

            migrationBuilder.CreateIndex(
                name: "IX_InjectedInsulins_IsDeleted",
                table: "InjectedInsulins",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Insulins_IsDeleted",
                table: "Insulins",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SportActivities_DiabeticDiaryId",
                table: "SportActivities",
                column: "DiabeticDiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_SportActivities_IsDeleted",
                table: "SportActivities",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodGlucoses");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "InjectedInsulins");

            migrationBuilder.DropTable(
                name: "SportActivities");

            migrationBuilder.DropTable(
                name: "CarbohidrateIntakes");

            migrationBuilder.DropTable(
                name: "Insulins");

            migrationBuilder.DropTable(
                name: "DiabeticDiaries");
        }
    }
}
