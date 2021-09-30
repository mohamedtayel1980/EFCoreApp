using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApp.Migrations
{
    public partial class AdditionalRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IndexForName",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("7aeebf96-8364-4665-9260-869a2082f42f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9e4524ed-2d59-4014-8335-2cd268022bb9"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("7aeebf96-8364-4665-9260-869a2082f42f"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("9e4524ed-2d59-4014-8335-2cd268022bb9"), 25, "Jane Doe" });

            migrationBuilder.CreateIndex(
                name: "IndexForName",
                table: "Student",
                column: "Name");
        }
    }
}
