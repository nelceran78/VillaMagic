using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class CambiodePropiedadROl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 27, 24, 501, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 7, 6, 11, 27, 24, 501, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 27, 24, 501, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 7, 6, 11, 27, 24, 501, DateTimeKind.Local).AddTicks(4600) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 55, 37, 678, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 7, 5, 11, 55, 37, 678, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 55, 37, 678, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 7, 5, 11, 55, 37, 678, DateTimeKind.Local).AddTicks(8932) });
        }
    }
}
