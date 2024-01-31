using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciceFakeDb.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monkeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monkeys", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Monkeys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chen" },
                    { 2, "Jean" },
                    { 3, "Sawa" },
                    { 4, "Chen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monkeys");
        }
    }
}
