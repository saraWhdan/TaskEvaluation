using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskEvaluation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EntryDate", "IsCompleted", "IsDeleted", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, false, false, "Front End", null },
                    { 2, null, false, false, "Back End", null }
                });

            migrationBuilder.InsertData(
                table: "EvalutionGrades",
                columns: new[] { "Id", "EntryDate", "Grade", "IsDeleted", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, "Good", false, null },
                    { 2, null, "Very good", false, null },
                    { 3, null, "Excellent", false, null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CourseId", "EntryDate", "IsDeleted", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, null, false, "A", null },
                    { 2, 2, null, false, "B", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvalutionGrades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EvalutionGrades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EvalutionGrades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
