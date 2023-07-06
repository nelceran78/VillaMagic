using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class CambiodePropiedadRoltoString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rol",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 35, 54, 134, DateTimeKind.Local).AddTicks(5332), new DateTime(2023, 7, 6, 11, 35, 54, 134, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 35, 54, 134, DateTimeKind.Local).AddTicks(5335), new DateTime(2023, 7, 6, 11, 35, 54, 134, DateTimeKind.Local).AddTicks(5335) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rol",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
