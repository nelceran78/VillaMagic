using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa Real", new DateTime(2023, 6, 29, 13, 9, 47, 953, DateTimeKind.Local).AddTicks(942), new DateTime(2023, 6, 29, 13, 9, 47, 953, DateTimeKind.Local).AddTicks(922), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa Real Premium", new DateTime(2023, 6, 29, 13, 9, 47, 953, DateTimeKind.Local).AddTicks(946), new DateTime(2023, 6, 29, 13, 9, 47, 953, DateTimeKind.Local).AddTicks(945), "", 40, "Villa Real Premiun", 4, 250.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
