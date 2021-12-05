using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCondominio.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    TipoDocumento = table.Column<string>(type: "TEXT", nullable: true),
                    Documento = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Correo = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "TipoAlquiler",
                columns: table => new
                {
                    IdTipoAlquiler = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Dias = table.Column<int>(type: "INTEGER", nullable: false),
                    DefinidoSistema = table.Column<int>(type: "INTEGER", nullable: false),
                    AplicaDias = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAlquiler", x => x.IdTipoAlquiler);
                });

            migrationBuilder.CreateTable(
                name: "TipoInmueble",
                columns: table => new
                {
                    IdTipoInmueble = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoInmueble", x => x.IdTipoInmueble);
                });

            migrationBuilder.CreateTable(
                name: "TipoMoneda",
                columns: table => new
                {
                    IdTipoMoneda = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMoneda", x => x.IdTipoMoneda);
                });

            migrationBuilder.CreateTable(
                name: "Vista",
                columns: table => new
                {
                    VistaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoContrato = table.Column<string>(type: "TEXT", nullable: true),
                    NombreCliente = table.Column<string>(type: "TEXT", nullable: true),
                    TipoAlquiler = table.Column<string>(type: "TEXT", nullable: true),
                    TipoInmueble = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroPeriodo = table.Column<string>(type: "TEXT", nullable: true),
                    FechaLimite = table.Column<string>(type: "TEXT", nullable: true),
                    MontoDeuda = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vista", x => x.VistaId);
                });

            migrationBuilder.CreateTable(
                name: "Inmueble",
                columns: table => new
                {
                    IdInmueble = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(type: "TEXT", nullable: true),
                    IdTipoInmueble = table.Column<int>(type: "INTEGER", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioAlquiler = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmueble", x => x.IdInmueble);
                    table.ForeignKey(
                        name: "FK_Inmueble_TipoInmueble_IdTipoInmueble",
                        column: x => x.IdTipoInmueble,
                        principalTable: "TipoInmueble",
                        principalColumn: "IdTipoInmueble",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    IdAlquiler = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoAlquiler = table.Column<string>(type: "TEXT", nullable: true),
                    NombreCliente = table.Column<string>(type: "TEXT", nullable: true),
                    TipoDocumentoCliente = table.Column<string>(type: "TEXT", nullable: true),
                    DocumentoCliente = table.Column<string>(type: "TEXT", nullable: true),
                    TelefonoCliente = table.Column<string>(type: "TEXT", nullable: true),
                    CorreoCliente = table.Column<string>(type: "TEXT", nullable: true),
                    NacionalidadCliente = table.Column<string>(type: "TEXT", nullable: true),
                    IdInmueble = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTipoAlquiler = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTipoMoneda = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadPeriodo = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicioAlquiler = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFinAlquiler = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.IdAlquiler);
                    table.ForeignKey(
                        name: "FK_Alquiler_Inmueble_IdInmueble",
                        column: x => x.IdInmueble,
                        principalTable: "Inmueble",
                        principalColumn: "IdInmueble",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_TipoAlquiler_IdTipoAlquiler",
                        column: x => x.IdTipoAlquiler,
                        principalTable: "TipoAlquiler",
                        principalColumn: "IdTipoAlquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_TipoMoneda_IdTipoMoneda",
                        column: x => x.IdTipoMoneda,
                        principalTable: "TipoMoneda",
                        principalColumn: "IdTipoMoneda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Periodo",
                columns: table => new
                {
                    IdPeriodo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroPeriodo = table.Column<int>(type: "INTEGER", nullable: false),
                    IdAlquiler = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaLimitePeriodo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EstadoPeriodo = table.Column<string>(type: "TEXT", nullable: true),
                    ProximoPagar = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<decimal>(type: "TEXT", nullable: false),
                    FechaPago = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodo", x => x.IdPeriodo);
                    table.ForeignKey(
                        name: "FK_Periodo_Alquiler_IdAlquiler",
                        column: x => x.IdAlquiler,
                        principalTable: "Alquiler",
                        principalColumn: "IdAlquiler",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deuda",
                columns: table => new
                {
                    IdDeuda = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPeriodo = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroPeriodo = table.Column<int>(type: "INTEGER", nullable: false),
                    MontoDeuda = table.Column<string>(type: "TEXT", nullable: true),
                    EstadoDeuda = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPago = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deuda", x => x.IdDeuda);
                    table.ForeignKey(
                        name: "FK_Deuda_Periodo_IdPeriodo",
                        column: x => x.IdPeriodo,
                        principalTable: "Periodo",
                        principalColumn: "IdPeriodo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "IdCliente", "Clave", "Correo", "Documento", "Nombre", "Telefono", "TipoDocumento" },
                values: new object[] { 1, "1234", "cliente@gmail.com", "1234", "admin", "809-999-9999", "Cedula" });

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_IdInmueble",
                table: "Alquiler",
                column: "IdInmueble");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_IdTipoAlquiler",
                table: "Alquiler",
                column: "IdTipoAlquiler");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_IdTipoMoneda",
                table: "Alquiler",
                column: "IdTipoMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_Deuda_IdPeriodo",
                table: "Deuda",
                column: "IdPeriodo");

            migrationBuilder.CreateIndex(
                name: "IX_Inmueble_IdTipoInmueble",
                table: "Inmueble",
                column: "IdTipoInmueble");

            migrationBuilder.CreateIndex(
                name: "IX_Periodo_IdAlquiler",
                table: "Periodo",
                column: "IdAlquiler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Deuda");

            migrationBuilder.DropTable(
                name: "Vista");

            migrationBuilder.DropTable(
                name: "Periodo");

            migrationBuilder.DropTable(
                name: "Alquiler");

            migrationBuilder.DropTable(
                name: "Inmueble");

            migrationBuilder.DropTable(
                name: "TipoAlquiler");

            migrationBuilder.DropTable(
                name: "TipoMoneda");

            migrationBuilder.DropTable(
                name: "TipoInmueble");
        }
    }
}
