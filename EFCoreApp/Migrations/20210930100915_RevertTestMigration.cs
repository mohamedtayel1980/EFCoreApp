using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApp.Migrations
{
    public partial class RevertTestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("204bb500-da6b-46c6-b4b8-85f0e0f7e66b"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("8e4e5d16-7d0c-46ee-a68e-7ae773dfae79"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("b25caa4e-07bf-4aad-8175-687583c708b2"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("b25caa4e-07bf-4aad-8175-687583c708b2"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("204bb500-da6b-46c6-b4b8-85f0e0f7e66b"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("8e4e5d16-7d0c-46ee-a68e-7ae773dfae79"), 28, "Mike Miles" });
        }
    }
}
