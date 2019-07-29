using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloSchool.Migrations
{
    public partial class PrimeraM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PreRegistros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDocumento = table.Column<string>(nullable: true),
                    NoDocumento = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Parentesco = table.Column<string>(nullable: true),
                    TipoDocumentoEstudiante = table.Column<string>(nullable: true),
                    NoDocumentoEstudiante = table.Column<string>(nullable: true),
                    ApellidosEstudiante = table.Column<string>(nullable: true),
                    NombresEstudiante = table.Column<string>(nullable: true),
                    FechaNacimientoEstudiante = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRegistros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreRegistros");
        }
    }
}
