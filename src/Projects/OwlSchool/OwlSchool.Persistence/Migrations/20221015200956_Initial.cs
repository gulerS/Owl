using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OwlSchool.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[] { 1, 1, "Science 1" });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[] { 2, 2, "Science 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");
        }
    }
}
