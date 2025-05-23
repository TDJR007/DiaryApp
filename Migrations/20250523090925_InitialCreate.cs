using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went Hiking with Joe and Anne!", new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Went Hiking" },
                    { 2, "Went Shopping with my imaginary girlfriend!", new DateTime(2024, 5, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), "Went Shopping" },
                    { 3, "Went Diving with Joe!", new DateTime(2024, 5, 3, 9, 15, 0, 0, DateTimeKind.Unspecified), "Went Diving" },
                    { 4, "Walked some 385,000 kilometers. Leg Day.", new DateTime(2002, 8, 16, 7, 55, 22, 0, DateTimeKind.Unspecified), "Walking to the Moon." },
                    { 5, "Scrapping my Rolls Royce.", new DateTime(2030, 4, 15, 2, 10, 0, 0, DateTimeKind.Unspecified), "Visiting Mechanic Claude." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryEntries");
        }
    }
}
