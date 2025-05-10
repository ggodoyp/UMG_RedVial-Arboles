using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedVial_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intersecciones",
                columns: table => new
                {
                    IdInterseccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadVehiculosEspera = table.Column<int>(type: "int", nullable: false),
                    TipoViaNorte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoViaSur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoViaEste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoViaOeste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semaforo = table.Column<bool>(type: "bit", nullable: false),
                    TiempoPromedioTransito = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intersecciones", x => x.IdInterseccion);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    IdRuta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterseccionOrigenId = table.Column<int>(type: "int", nullable: false),
                    InterseccionDestinoId = table.Column<int>(type: "int", nullable: false),
                    IdVia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.IdRuta);
                });

            migrationBuilder.CreateTable(
                name: "Vias",
                columns: table => new
                {
                    IdVia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unidireccional = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vias", x => x.IdVia);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intersecciones");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "Vias");
        }
    }
}
