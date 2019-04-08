using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wodin.Migrations.Novo
{
    public partial class ajuste01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermissaoAcesso_PessoaUsuario_PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.RenameColumn(
                name: "PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioPermissaoAcesso_PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso",
                newName: "IX_UsuarioPermissaoAcesso_PessoaId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 568, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 85, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 568, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 85, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 550, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 67, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 550, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 67, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 84, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 566, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 84, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 565, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 82, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 564, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 82, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 563, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 80, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 563, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 80, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 561, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 78, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 561, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 78, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 559, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 76, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 559, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 76, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 556, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 73, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 556, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 73, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 558, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 74, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 558, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 74, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 553, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 71, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 553, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 70, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 551, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 68, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 551, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 68, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 549, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 66, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 549, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 66, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 545, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 62, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 544, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 60, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 547, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 63, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 547, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 63, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 8, 14, 32, 27, 548, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 8, 14, 32, 27, 546, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermissaoAcesso_Pessoa_PessoaId",
                table: "UsuarioPermissaoAcesso",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermissaoAcesso_Pessoa_PessoaId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "UsuarioPermissaoAcesso",
                newName: "PessoaUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioPermissaoAcesso_PessoaId",
                table: "UsuarioPermissaoAcesso",
                newName: "IX_UsuarioPermissaoAcesso_PessoaUsuarioId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 85, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 568, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 85, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 568, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 67, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 550, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 67, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 550, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 84, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 84, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 566, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 82, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 565, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 82, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 564, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 80, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 563, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 80, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 563, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 78, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 561, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 78, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 561, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 76, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 559, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 76, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 559, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 73, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 556, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 73, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 556, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 74, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 558, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 74, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 558, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 71, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 553, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 70, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 553, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 68, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 551, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 68, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 551, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 66, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 549, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 66, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 549, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 62, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 545, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 60, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 544, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 63, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 547, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 8, 13, 37, 41, 63, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 8, 14, 32, 27, 547, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 8, 13, 37, 41, 63, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 8, 13, 37, 41, 63, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermissaoAcesso_PessoaUsuario_PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso",
                column: "PessoaUsuarioId",
                principalTable: "PessoaUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
