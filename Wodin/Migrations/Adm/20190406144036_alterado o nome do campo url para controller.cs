using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wodin.Migrations.Adm
{
    public partial class alteradoonomedocampourlparacontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "SubMenu",
                newName: "Controller");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Menu",
                newName: "Controller");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "SubMenu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 654, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "SubMenu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 654, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 567, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Menu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 653, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Menu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 653, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 651, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 564, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 650, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 562, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 11, 40, 36, 652, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 11, 40, 36, 652, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Controller",
                table: "SubMenu",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Controller",
                table: "Menu",
                newName: "Url");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "SubMenu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 654, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "SubMenu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 567, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 654, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Menu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 653, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Menu",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 653, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 564, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 651, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 11, 5, 13, 562, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 11, 40, 36, 650, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 11, 5, 13, 564, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 11, 5, 13, 564, DateTimeKind.Local));
        }
    }
}
