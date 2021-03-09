using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "b01d8893-8c7d-45f0-b7ef-c481536a35cd", "Jane", "Smith", "Medicine" },
                    { "88cf53cd-ce3d-46ed-bbeb-3312dff45dbf", "John", "Fisher", "Engineering" },
                    { "3e974266-cee4-4a0e-99d5-5d67b8345eb1", "Pamela", "Baker", "Food Science" },
                    { "bc139a10-e982-45d8-8d8e-42b23be274cc", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
