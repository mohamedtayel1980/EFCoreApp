using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApp.Migrations
{
    public partial class StudentEvaluations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("0982f0e2-2934-4653-acde-b8fddc05aa88"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a3ce5cb3-708e-46cd-b3c3-d3c481f936ab"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("aca7d57b-b6a1-49bf-b1c4-da9164be0b91"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("b3d53a12-2cdd-4b11-9f85-15873cb4374f"));

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    AdditionalExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("c3e5ffbb-d825-47e7-ae54-f2f65a050ab9"), 30, "John Doe" },
                    { new Guid("81812332-e777-4de9-b6ea-d95d0e644ed9"), 25, "Jane Doe" },
                    { new Guid("b62b8470-e44b-45ec-bd95-091a32565b43"), 28, "Mike Miles" },
                    { new Guid("e935b0da-f9cb-4db5-a93e-cf2f0673346a"), 100, "TEST Name" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluation",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("81812332-e777-4de9-b6ea-d95d0e644ed9"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("b62b8470-e44b-45ec-bd95-091a32565b43"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c3e5ffbb-d825-47e7-ae54-f2f65a050ab9"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("e935b0da-f9cb-4db5-a93e-cf2f0673346a"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("a3ce5cb3-708e-46cd-b3c3-d3c481f936ab"), 30, "John Doe" },
                    { new Guid("b3d53a12-2cdd-4b11-9f85-15873cb4374f"), 25, "Jane Doe" },
                    { new Guid("0982f0e2-2934-4653-acde-b8fddc05aa88"), 28, "Mike Miles" },
                    { new Guid("aca7d57b-b6a1-49bf-b1c4-da9164be0b91"), 100, "TEST Name" }
                });
        }
    }
}
