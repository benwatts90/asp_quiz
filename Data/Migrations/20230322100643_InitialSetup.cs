using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.Data.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    q = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wa1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wa2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
