using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class DemoEFCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablePerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Jean"),
                    LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSEUDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablePerson", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablePerson_PSEUDO",
                table: "TablePerson",
                column: "PSEUDO",
                unique: true,
                filter: "[PSEUDO] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablePerson");
        }
    }
}
