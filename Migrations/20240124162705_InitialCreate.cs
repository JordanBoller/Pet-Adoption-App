using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace midterm_project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PetName = table.Column<string>(type: "TEXT", nullable: false),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: false),
                    PetDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
