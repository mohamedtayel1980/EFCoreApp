using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApp.Migrations
{
    public partial class OneToOneRelationshipStudent_StudentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("11b1ff95-acfc-4fb7-a8b8-fc3f8e1800cb"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("32e3b590-0efc-4975-8265-b381f3641584"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("8cccad72-baf8-4d58-ad8e-92d1305f02c4"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("91b0c086-5a12-42f6-8786-14ac8bf7b916"));

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentDetailsId);
                    table.ForeignKey(
                        name: "FK_StudentDetails_Student_StudentId",
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
                    { new Guid("a3ce5cb3-708e-46cd-b3c3-d3c481f936ab"), 30, "John Doe" },
                    { new Guid("b3d53a12-2cdd-4b11-9f85-15873cb4374f"), 25, "Jane Doe" },
                    { new Guid("0982f0e2-2934-4653-acde-b8fddc05aa88"), 28, "Mike Miles" },
                    { new Guid("aca7d57b-b6a1-49bf-b1c4-da9164be0b91"), 100, "TEST Name" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_StudentId",
                table: "StudentDetails",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetails");

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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("11b1ff95-acfc-4fb7-a8b8-fc3f8e1800cb"), 30, "John Doe" },
                    { new Guid("8cccad72-baf8-4d58-ad8e-92d1305f02c4"), 25, "Jane Doe" },
                    { new Guid("91b0c086-5a12-42f6-8786-14ac8bf7b916"), 28, "Mike Miles" },
                    { new Guid("32e3b590-0efc-4975-8265-b381f3641584"), 100, "TEST Name" }
                });
        }
    }
}
