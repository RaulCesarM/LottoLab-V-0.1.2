using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LottoLab.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotoFacil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Concurso = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Casa_1 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_2 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_3 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_4 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_5 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_6 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_7 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_8 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_9 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_10 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_11 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_12 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_13 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_14 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_15 = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotoFacil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LotoFacilDelay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Concurso = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    bola1 = table.Column<int>(type: "int", nullable: false),
                    bola2 = table.Column<int>(type: "int", nullable: false),
                    bola3 = table.Column<int>(type: "int", nullable: false),
                    bola4 = table.Column<int>(type: "int", nullable: false),
                    bola5 = table.Column<int>(type: "int", nullable: false),
                    bola6 = table.Column<int>(type: "int", nullable: false),
                    bola7 = table.Column<int>(type: "int", nullable: false),
                    bola8 = table.Column<int>(type: "int", nullable: false),
                    bola9 = table.Column<int>(type: "int", nullable: false),
                    bola10 = table.Column<int>(type: "int", nullable: false),
                    bola11 = table.Column<int>(type: "int", nullable: false),
                    bola12 = table.Column<int>(type: "int", nullable: false),
                    bola13 = table.Column<int>(type: "int", nullable: false),
                    bola14 = table.Column<int>(type: "int", nullable: false),
                    bola15 = table.Column<int>(type: "int", nullable: false),
                    bola16 = table.Column<int>(type: "int", nullable: false),
                    bola17 = table.Column<int>(type: "int", nullable: false),
                    bola18 = table.Column<int>(type: "int", nullable: false),
                    bola19 = table.Column<int>(type: "int", nullable: false),
                    bola20 = table.Column<int>(type: "int", nullable: false),
                    bola21 = table.Column<int>(type: "int", nullable: false),
                    bola22 = table.Column<int>(type: "int", nullable: false),
                    bola23 = table.Column<int>(type: "int", nullable: false),
                    bola24 = table.Column<int>(type: "int", nullable: false),
                    bola25 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotoFacilDelay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LotoFacilRNA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Concurso = table.Column<string>(type: "char(64)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    bola1 = table.Column<string>(type: "char(1)", nullable: false),
                    bola2 = table.Column<string>(type: "char(1)", nullable: false),
                    bola3 = table.Column<string>(type: "char(1)", nullable: false),
                    bola4 = table.Column<string>(type: "char(1)", nullable: false),
                    bola5 = table.Column<string>(type: "char(1)", nullable: false),
                    bola6 = table.Column<string>(type: "char(1)", nullable: false),
                    bola7 = table.Column<string>(type: "char(1)", nullable: false),
                    bola8 = table.Column<string>(type: "char(1)", nullable: false),
                    bola9 = table.Column<string>(type: "char(1)", nullable: false),
                    bola10 = table.Column<string>(type: "char(1)", nullable: false),
                    bola11 = table.Column<string>(type: "char(1)", nullable: false),
                    bola12 = table.Column<string>(type: "char(1)", nullable: false),
                    bola13 = table.Column<string>(type: "char(1)", nullable: false),
                    bola14 = table.Column<string>(type: "char(1)", nullable: false),
                    bola15 = table.Column<string>(type: "char(1)", nullable: false),
                    bola16 = table.Column<string>(type: "char(1)", nullable: false),
                    bola17 = table.Column<string>(type: "char(1)", nullable: false),
                    bola18 = table.Column<string>(type: "char(1)", nullable: false),
                    bola19 = table.Column<string>(type: "char(1)", nullable: false),
                    bola20 = table.Column<string>(type: "char(1)", nullable: false),
                    bola21 = table.Column<string>(type: "char(1)", nullable: false),
                    bola22 = table.Column<string>(type: "char(1)", nullable: false),
                    bola23 = table.Column<string>(type: "char(1)", nullable: false),
                    bola24 = table.Column<string>(type: "char(1)", nullable: false),
                    bola25 = table.Column<string>(type: "char(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotoFacilRNA", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotoFacil");

            migrationBuilder.DropTable(
                name: "LotoFacilDelay");

            migrationBuilder.DropTable(
                name: "LotoFacilRNA");
        }
    }
}
