using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApp.Migrations
{
    public partial class StudentSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("098ba810-d4d9-4b91-970a-cf532f53691a"), 30, "John Doe" },
                    { new Guid("a34be877-c539-4da7-9c18-2ca1b259e0a0"), 25, "Jane Doe" },
                    { new Guid("aef0c73f-8237-4ec3-b044-092f89020910"), 28, "Mike Miles" },
                    { new Guid("3f6b4707-101d-460d-b3dc-dc9d30491677"), 100, "TEST Name" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("098ba810-d4d9-4b91-970a-cf532f53691a"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3f6b4707-101d-460d-b3dc-dc9d30491677"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a34be877-c539-4da7-9c18-2ca1b259e0a0"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("aef0c73f-8237-4ec3-b044-092f89020910"));

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
        }
    }
}
