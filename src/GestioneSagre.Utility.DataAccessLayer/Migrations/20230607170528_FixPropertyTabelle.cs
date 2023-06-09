using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestioneSagre.Utility.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class FixPropertyTabelle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScontrinoPagato",
                keyColumn: "Id",
                keyValue: new Guid("5168436b-4618-4fcc-957d-ab1974e16cbe"));

            migrationBuilder.DeleteData(
                table: "ScontrinoPagato",
                keyColumn: "Id",
                keyValue: new Guid("95e5b0c1-a51a-4d29-91a7-db01c49f5f3f"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("0e838069-6094-4fca-ad09-4fca2cee173e"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("19f815c8-2018-47a3-a6e9-be0bac57205a"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("318b6631-1c19-4e06-bd1f-bf14e86a8d24"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("d5199f4a-df16-40af-8100-2c4c4f78466f"));

            migrationBuilder.DeleteData(
                table: "ScontrinoStato",
                keyColumn: "Id",
                keyValue: new Guid("da58ff5f-0f08-4d0b-8942-1e080fea763c"));

            migrationBuilder.DeleteData(
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: new Guid("1c48295b-6dec-4e82-9377-787961208a48"));

            migrationBuilder.DeleteData(
                table: "TipoCliente",
                keyColumn: "Id",
                keyValue: new Guid("4e1a05a4-2655-4466-b3cc-8ba3e2dbe271"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("9a3b35b1-0640-4d6d-8952-e56c5962c15c"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("a7e910b0-67c9-4913-a279-e43674375bcf"));

            migrationBuilder.DeleteData(
                table: "TipoPagamento",
                keyColumn: "Id",
                keyValue: new Guid("bbd45d77-33de-42df-ba62-573e7953153b"));

            migrationBuilder.DeleteData(
                table: "TipoScontrino",
                keyColumn: "Id",
                keyValue: new Guid("4237bc9e-8751-4340-a31d-7babab87cc72"));

            migrationBuilder.DeleteData(
                table: "TipoScontrino",
                keyColumn: "Id",
                keyValue: new Guid("eb036a5f-95bc-4818-ac5a-e14655604b06"));

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "TipoScontrino",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "TipoPagamento",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "TipoCliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ScontrinoStato",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ScontrinoPagato",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "TipoScontrino",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "TipoPagamento",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "TipoCliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ScontrinoStato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ScontrinoPagato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "ScontrinoPagato",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("5168436b-4618-4fcc-957d-ab1974e16cbe"), "Pagato" },
                    { new Guid("95e5b0c1-a51a-4d29-91a7-db01c49f5f3f"), "Non pagato" }
                });

            migrationBuilder.InsertData(
                table: "ScontrinoStato",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("0e838069-6094-4fca-ad09-4fca2cee173e"), "Chiuso" },
                    { new Guid("19f815c8-2018-47a3-a6e9-be0bac57205a"), "In elaborazione" },
                    { new Guid("318b6631-1c19-4e06-bd1f-bf14e86a8d24"), "Annullato" },
                    { new Guid("d5199f4a-df16-40af-8100-2c4c4f78466f"), "Da incassare" },
                    { new Guid("da58ff5f-0f08-4d0b-8942-1e080fea763c"), "Aperto" }
                });

            migrationBuilder.InsertData(
                table: "TipoCliente",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("1c48295b-6dec-4e82-9377-787961208a48"), "Cliente" },
                    { new Guid("4e1a05a4-2655-4466-b3cc-8ba3e2dbe271"), "Staff" }
                });

            migrationBuilder.InsertData(
                table: "TipoPagamento",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("9a3b35b1-0640-4d6d-8952-e56c5962c15c"), "Carta di debito" },
                    { new Guid("a7e910b0-67c9-4913-a279-e43674375bcf"), "Carta di credito" },
                    { new Guid("bbd45d77-33de-42df-ba62-573e7953153b"), "Contanti" }
                });

            migrationBuilder.InsertData(
                table: "TipoScontrino",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("4237bc9e-8751-4340-a31d-7babab87cc72"), "Pagamento" },
                    { new Guid("eb036a5f-95bc-4818-ac5a-e14655604b06"), "Omaggio" }
                });
        }
    }
}
