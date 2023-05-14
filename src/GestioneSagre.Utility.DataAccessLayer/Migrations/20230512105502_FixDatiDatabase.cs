using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestioneSagre.Utility.DataAccessLayer.Migrations
{
    public partial class FixDatiDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScontrinoPagato",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-066c-753a-8e4b8c020f59"));

            migrationBuilder.DeleteData(
                table: "ScontrinoPagato",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0681-753a-8e4b8c020f5a"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0dd8-753a-8e4b8c020f5b"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0ddb-753a-8e4b8c020f5c"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0dde-753a-8e4b8c020f5d"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0de0-753a-8e4b8c020f5e"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0de3-753a-8e4b8c020f5f"));

            migrationBuilder.DeleteData(
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0e63-753a-8e4b8c020f60"));

            migrationBuilder.DeleteData(
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0e66-753a-8e4b8c020f61"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0f49-753a-8e4b8c020f64"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0f4c-753a-8e4b8c020f65"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0f4f-753a-8e4b8c020f66"));

            migrationBuilder.DeleteData(
                table: "TipoScontrino",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0ed2-753a-8e4b8c020f62"));

            migrationBuilder.DeleteData(
                table: "TipoScontrino",
                keyColumn: "Id",
                keyValue: new Guid("08db403c-b0d9-0ed5-753a-8e4b8c020f63"));

            migrationBuilder.InsertData(
                table: "ScontrinoPagato",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db52d7-561c-8fe8-753a-8e6e38038a41"), "Pagato" },
                    { new Guid("08db52d7-561c-9001-753a-8e6e38038a42"), "Non pagato" }
                });

            migrationBuilder.InsertData(
                table: "ScontrinoStato",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db52d7-561c-90e5-753a-8e6e38038a43"), "Aperto" },
                    { new Guid("08db52d7-561c-90e9-753a-8e6e38038a44"), "In elaborazione" },
                    { new Guid("08db52d7-561c-90ec-753a-8e6e38038a45"), "Da incassare" },
                    { new Guid("08db52d7-561c-90ef-753a-8e6e38038a46"), "Chiuso" },
                    { new Guid("08db52d7-561c-90f1-753a-8e6e38038a47"), "Annullato" }
                });

            migrationBuilder.InsertData(
                table: "TipoCliente",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db52d7-561c-9170-753a-8e6e38038a48"), "Cliente" },
                    { new Guid("08db52d7-561c-9173-753a-8e6e38038a49"), "Staff" }
                });

            migrationBuilder.InsertData(
                table: "TipoPagamento",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db52d7-561c-924e-753a-8e6e38038a4c"), "Contanti" },
                    { new Guid("08db52d7-561c-9252-753a-8e6e38038a4d"), "Carta di credito" },
                    { new Guid("08db52d7-561c-9255-753a-8e6e38038a4e"), "Carta di debito" }
                });

            migrationBuilder.InsertData(
                table: "TipoScontrino",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("08db52d7-561c-91d7-753a-8e6e38038a4a"), "Pagamento" },
                    { new Guid("08db52d7-561c-91da-753a-8e6e38038a4b"), "Omaggio" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScontrinoPagato",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-8fe8-753a-8e6e38038a41"));

            migrationBuilder.DeleteData(
                table: "ScontrinoPagato",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-9001-753a-8e6e38038a42"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-90e5-753a-8e6e38038a43"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-90e9-753a-8e6e38038a44"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-90ec-753a-8e6e38038a45"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-90ef-753a-8e6e38038a46"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-90f1-753a-8e6e38038a47"));

            migrationBuilder.DeleteData(
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-9170-753a-8e6e38038a48"));

            migrationBuilder.DeleteData(
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-9173-753a-8e6e38038a49"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-924e-753a-8e6e38038a4c"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-9252-753a-8e6e38038a4d"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-9255-753a-8e6e38038a4e"));

            migrationBuilder.DeleteData(
                table: "TipoScontrino",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-91d7-753a-8e6e38038a4a"));

            migrationBuilder.DeleteData(
                table: "TipoScontrino",
                keyColumn: "Id",
                keyValue: new Guid("08db52d7-561c-91da-753a-8e6e38038a4b"));

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
    }
}
