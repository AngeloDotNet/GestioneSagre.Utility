using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestioneSagre.Utility.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScontrinoPagato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScontrinoPagato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScontrinoStato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScontrinoStato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoScontrino",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoScontrino", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ScontrinoPagato",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db403c-b0d9-066c-753a-8e4b8c020f59"), "Pagato" },
                    { new Guid("08db403c-b0d9-0681-753a-8e4b8c020f5a"), "Non pagato" }
                });

            migrationBuilder.InsertData(
                table: "ScontrinoStato",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db403c-b0d9-0dd8-753a-8e4b8c020f5b"), "Aperto" },
                    { new Guid("08db403c-b0d9-0ddb-753a-8e4b8c020f5c"), "In elaborazione" },
                    { new Guid("08db403c-b0d9-0dde-753a-8e4b8c020f5d"), "Da incassare" },
                    { new Guid("08db403c-b0d9-0de0-753a-8e4b8c020f5e"), "Chiuso" },
                    { new Guid("08db403c-b0d9-0de3-753a-8e4b8c020f5f"), "Annullato" }
                });

            migrationBuilder.InsertData(
                table: "TipoCliente",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db403c-b0d9-0e63-753a-8e4b8c020f60"), "Cliente" },
                    { new Guid("08db403c-b0d9-0e66-753a-8e4b8c020f61"), "Staff" }
                });

            migrationBuilder.InsertData(
                table: "TipoPagamento",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db403c-b0d9-0f49-753a-8e4b8c020f64"), "Contanti" },
                    { new Guid("08db403c-b0d9-0f4c-753a-8e4b8c020f65"), "Carta di credito" },
                    { new Guid("08db403c-b0d9-0f4f-753a-8e4b8c020f66"), "Carta di debito" }
                });

            migrationBuilder.InsertData(
                table: "TipoScontrino",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db403c-b0d9-0ed2-753a-8e4b8c020f62"), "Pagamento" },
                    { new Guid("08db403c-b0d9-0ed5-753a-8e4b8c020f63"), "Omaggio" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScontrinoPagato");

            migrationBuilder.DropTable(
                name: "ScontrinoStato");

            migrationBuilder.DropTable(
                name: "TipoCliente");

            migrationBuilder.DropTable(
                name: "TipoPagamento");

            migrationBuilder.DropTable(
                name: "TipoScontrino");
        }
    }
}
