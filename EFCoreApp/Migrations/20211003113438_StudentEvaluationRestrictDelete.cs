using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApp.Migrations
{
    public partial class StudentEvaluationRestrictDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

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
                    { new Guid("ebcbe3d0-2bd6-46bf-bdcb-d0e8fabd8b01"), 30, "John Doe" },
                    { new Guid("56dc1c08-82cc-4dcc-b82d-940c224a9310"), 25, "Jane Doe" },
                    { new Guid("7c79edf6-f103-47d5-84aa-4a458224b77e"), 28, "Mike Miles" },
                    { new Guid("0c0ac9ac-34e3-4a56-b673-038699c96b94"), 100, "TEST Name" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("0c0ac9ac-34e3-4a56-b673-038699c96b94"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("56dc1c08-82cc-4dcc-b82d-940c224a9310"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("7c79edf6-f103-47d5-84aa-4a458224b77e"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("ebcbe3d0-2bd6-46bf-bdcb-d0e8fabd8b01"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
