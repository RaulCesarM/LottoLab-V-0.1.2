using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LottoLab.Migrations
{
    /// <inheritdoc />
    public partial class Initia12l : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "bola9",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola8",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola7",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola6",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola5",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola4",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola3",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola25",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola24",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola23",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola22",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola21",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola20",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola2",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola19",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola18",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola17",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola16",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola15",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola14",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola13",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola12",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola11",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola10",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "bola1",
                table: "LotoFacilRNA",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "Concurso",
                table: "LotoFacilRNA",
                type: "char(64)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.CreateTable(
                name: "LotoFacilMostDown",
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
                    table.PrimaryKey("PK_LotoFacilMostDown", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotoFacilMostDown");

            migrationBuilder.AlterColumn<string>(
                name: "bola9",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola8",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola7",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola6",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola5",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola4",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola3",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola25",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola24",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola23",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola22",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola21",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola20",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola2",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola19",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola18",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola17",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola16",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola15",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola14",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola13",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola12",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola11",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola10",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bola1",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Concurso",
                table: "LotoFacilRNA",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(64)");
        }
    }
}
