using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlucoCare.Data.Migrations
{
    public partial class InitialeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "InsulinSensibility",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DayParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsulinNeedRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodPlan_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insulins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsulinType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiabeticId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insulins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insulins_AspNetUsers_DiabeticId",
                        column: x => x.DiabeticId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InsulinNeeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsulinDose = table.Column<int>(type: "int", nullable: false),
                    InjectionTimeBeforeEating = table.Column<TimeSpan>(type: "time", nullable: false),
                    DayPartId = table.Column<int>(type: "int", nullable: false),
                    CarbohidrateIntakeId = table.Column<int>(type: "int", nullable: true),
                    SportActivityId = table.Column<int>(type: "int", nullable: false),
                    BloodGlucoseId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsulinNeeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsulinNeeds_DayParts_DayPartId",
                        column: x => x.DayPartId,
                        principalTable: "DayParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BloodGlucoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentGlucoseLevel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiabeticId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InsulinNeedId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGlucoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodGlucoses_AspNetUsers_DiabeticId",
                        column: x => x.DiabeticId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BloodGlucoses_InsulinNeeds_InsulinNeedId",
                        column: x => x.InsulinNeedId,
                        principalTable: "InsulinNeeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarbohidrateIntakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    InsulinNeedId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbohidrateIntakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarbohidrateIntakes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarbohidrateIntakes_InsulinNeeds_InsulinNeedId",
                        column: x => x.InsulinNeedId,
                        principalTable: "InsulinNeeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SportActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsulinNeedId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportActivities_InsulinNeeds_InsulinNeedId",
                        column: x => x.InsulinNeedId,
                        principalTable: "InsulinNeeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grams = table.Column<int>(type: "int", nullable: false),
                    GlycemicIndex = table.Column<int>(type: "int", nullable: false),
                    CarbohydratePer100Grams = table.Column<double>(type: "float", nullable: false),
                    FatPer100Grams = table.Column<double>(type: "float", nullable: false),
                    WaterPer100Grams = table.Column<double>(type: "float", nullable: false),
                    ProteinPer100Grams = table.Column<double>(type: "float", nullable: false),
                    CaloriesPer100Grams = table.Column<double>(type: "float", nullable: false),
                    CarbohidrateIntakeId = table.Column<int>(type: "int", nullable: false),
                    FoodTypeId = table.Column<int>(type: "int", nullable: false),
                    FoodPlanId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_CarbohidrateIntakes_CarbohidrateIntakeId",
                        column: x => x.CarbohidrateIntakeId,
                        principalTable: "CarbohidrateIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_FoodPlan_FoodPlanId",
                        column: x => x.FoodPlanId,
                        principalTable: "FoodPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_FoodType_FoodTypeId",
                        column: x => x.FoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodGlucoses_DiabeticId",
                table: "BloodGlucoses",
                column: "DiabeticId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodGlucoses_InsulinNeedId",
                table: "BloodGlucoses",
                column: "InsulinNeedId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodGlucoses_IsDeleted",
                table: "BloodGlucoses",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CarbohidrateIntakes_InsulinNeedId",
                table: "CarbohidrateIntakes",
                column: "InsulinNeedId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarbohidrateIntakes_IsDeleted",
                table: "CarbohidrateIntakes",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CarbohidrateIntakes_UserId",
                table: "CarbohidrateIntakes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DayParts_IsDeleted",
                table: "DayParts",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FoodPlan_IsDeleted",
                table: "FoodPlan",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FoodPlan_UserId",
                table: "FoodPlan",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CarbohidrateIntakeId",
                table: "Foods",
                column: "CarbohidrateIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodPlanId",
                table: "Foods",
                column: "FoodPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodTypeId",
                table: "Foods",
                column: "FoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_IsDeleted",
                table: "Foods",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FoodType_IsDeleted",
                table: "FoodType",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_InsulinNeeds_BloodGlucoseId",
                table: "InsulinNeeds",
                column: "BloodGlucoseId");

            migrationBuilder.CreateIndex(
                name: "IX_InsulinNeeds_DayPartId",
                table: "InsulinNeeds",
                column: "DayPartId");

            migrationBuilder.CreateIndex(
                name: "IX_InsulinNeeds_IsDeleted",
                table: "InsulinNeeds",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_InsulinNeeds_SportActivityId",
                table: "InsulinNeeds",
                column: "SportActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Insulins_DiabeticId",
                table: "Insulins",
                column: "DiabeticId");

            migrationBuilder.CreateIndex(
                name: "IX_Insulins_IsDeleted",
                table: "Insulins",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SportActivities_InsulinNeedId",
                table: "SportActivities",
                column: "InsulinNeedId");

            migrationBuilder.CreateIndex(
                name: "IX_SportActivities_IsDeleted",
                table: "SportActivities",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_InsulinNeeds_BloodGlucoses_BloodGlucoseId",
                table: "InsulinNeeds",
                column: "BloodGlucoseId",
                principalTable: "BloodGlucoses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsulinNeeds_SportActivities_SportActivityId",
                table: "InsulinNeeds",
                column: "SportActivityId",
                principalTable: "SportActivities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodGlucoses_InsulinNeeds_InsulinNeedId",
                table: "BloodGlucoses");

            migrationBuilder.DropForeignKey(
                name: "FK_SportActivities_InsulinNeeds_InsulinNeedId",
                table: "SportActivities");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Insulins");

            migrationBuilder.DropTable(
                name: "CarbohidrateIntakes");

            migrationBuilder.DropTable(
                name: "FoodPlan");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "InsulinNeeds");

            migrationBuilder.DropTable(
                name: "BloodGlucoses");

            migrationBuilder.DropTable(
                name: "DayParts");

            migrationBuilder.DropTable(
                name: "SportActivities");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InsulinSensibility",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "AspNetUsers");
        }
    }
}
