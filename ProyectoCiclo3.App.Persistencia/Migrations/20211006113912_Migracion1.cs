using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "presentacion",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "tipo",
                table: "Aviones");

            migrationBuilder.AddColumn<int>(
                name: "capacidad_max_carga",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numero_asientos",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numero_banos",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Aeropuertos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coord_x = table.Column<int>(type: "int", nullable: false),
                    coord_y = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeropuertos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origen = table.Column<int>(type: "int", nullable: false),
                    destino = table.Column<int>(type: "int", nullable: false),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeropuertos");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropColumn(
                name: "capacidad_max_carga",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "numero_asientos",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "numero_banos",
                table: "Aviones");

            migrationBuilder.AddColumn<string>(
                name: "presentacion",
                table: "Aviones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipo",
                table: "Aviones",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
